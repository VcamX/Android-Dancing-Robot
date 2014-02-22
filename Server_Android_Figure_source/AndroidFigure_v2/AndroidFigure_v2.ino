#include <Servo.h>
#include <Firmata.h>

byte previousPORT[TOTAL_PORTS]; 
Servo servos[MAX_SERVOS];

void setPinModeCallback(byte pin, int mode) {
  switch(mode) {
  case OUTPUT:
    if (IS_PIN_DIGITAL(pin)) {
      pinMode(PIN_TO_DIGITAL(pin), OUTPUT);
    }
    break;
  case SERVO:
    if (IS_PIN_SERVO(pin)) {
      if (!servos[PIN_TO_SERVO(pin)].attached()) {
          servos[PIN_TO_SERVO(pin)].attach(PIN_TO_DIGITAL(pin));
      }
    }
    break;
  }
}

void analogWriteCallback(byte pin, int value)
{
  if (IS_PIN_SERVO(pin))
  {
    servos[PIN_TO_SERVO(pin)].write(value);
  }
}

void digitalWriteCallback(byte port, int value)
{
    byte i;
    byte currentPinValue, previousPinValue;

    if (port < TOTAL_PORTS && value != previousPORT[port]) {
        for(i=0; i<8; i++) {
            currentPinValue = (byte) value & (1 << i);
            previousPinValue = previousPORT[port] & (1 << i);
            if(currentPinValue != previousPinValue) {
                digitalWrite(i + (port*8), currentPinValue);
            }
        }
        previousPORT[port] = value;
    }
}

void setup() 
{
    Firmata.setFirmwareVersion(0, 2);
    Firmata.attach(DIGITAL_MESSAGE, digitalWriteCallback);
    Firmata.attach(SET_PIN_MODE, setPinModeCallback);
    Firmata.attach(ANALOG_MESSAGE, analogWriteCallback);
    Firmata.begin(57600);
}

void loop() 
{
    while(Firmata.available())
        Firmata.processInput();
}
