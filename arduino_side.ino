#include <MAX6675_Thermocouple.h>
#define DEBUG(a) Serial.println(a);

#define CONTROL_THERMOCOUPLE_SO_PIN 5
#define CONTROL_THERMOCOUPLE_CS_PIN 6
#define CONTROL_THERMOCOUPLE_SCK_PIN 7

#define LOWER_THERMOCOUPLE_SO_PIN 8
#define LOWER_THERMOCOUPLE_CS_PIN 9
#define LOWER_THERMOCOUPLE_SCK_PIN 10

#define UPPER_THERMOCOUPLE_SO_PIN 11
#define UPPER_THERMOCOUPLE_CS_PIN 12
#define UPPER_THERMOCOUPLE_SCK_PIN 13

#define SERIAL_DATA_RATE 9600

#define R1 22
#define R2 23
#define R3 24
#define R4 25
#define R5 26
#define R6 27
#define F1 28
#define F2 29

#define START_BUTTON_PRESSED 7
#define STOP_BUTTON_PRESSED 8
#define PAUSE_BUTTON_PRESSED 9

#define PAUSE_FAN_DURATION 5000
#define UPDATE_DELAY_DURATION 500

// Should this be measured at the beggining?
#define ROOM_TEMPERATURE 25

enum class State {
    NOT_STARTED,
    PAUSED_FANS_ON,
    PAUSED_FANS_OFF,
    PREHEAT,
    SOAK,
    REFLOW,
    COOLING,
    FINISHED
};

struct ChipConfigurationData {
    bool isValid = false;
    int damageTemperarure;
    int soakTemperature;
    int reflowTemperature;
    int preheatDuration;
    int soakDuration;
    int reflowDuration;
    int coolingDuration;
};

struct PinData {
    bool upperFanIsTurnedOn;
    bool lowerFanIsTurnedOn;
    bool lowerResistancesAreTurnedOn[4];
    bool upperResistanceIsTurnedOn;
    
    int controlTemperature;
    int lowerProbeTemperature;
    int upperProbeTemperature;
};

State pausedState = State::NOT_STARTED; // Stores the old state of the machine when it's paused.
State currentState = State::NOT_STARTED;
ChipConfigurationData chipConfigurationData;
unsigned long pauseStartTime = 0;
unsigned long currentStateStartTime = 0;

MAX6675_Thermocouple controlThermocouple(CONTROL_THERMOCOUPLE_SCK_PIN, CONTROL_THERMOCOUPLE_CS_PIN, CONTROL_THERMOCOUPLE_SO_PIN);
MAX6675_Thermocouple lowerThermocouple(LOWER_THERMOCOUPLE_SCK_PIN, LOWER_THERMOCOUPLE_CS_PIN, LOWER_THERMOCOUPLE_SO_PIN);
MAX6675_Thermocouple upperThermocouple(UPPER_THERMOCOUPLE_SCK_PIN, UPPER_THERMOCOUPLE_CS_PIN, UPPER_THERMOCOUPLE_SO_PIN);

void turnFanOn(int fanPort) {
    digitalWrite(fanPort, LOW);
}

void turnFanOff(int fanPort) {
    digitalWrite(fanPort, HIGH);
}

void turnAllFansOn() {
    turnFanOn(F1);
    turnFanOn(F2);
}

void turnAllFansOff() {
    turnFanOff(F1);
    turnFanOff(F2);
}

void turnResistanceOn(int resistancePort) {
    digitalWrite(resistancePort, HIGH);
}

void turnResistanceOff(int resistancePort) {
    digitalWrite(resistancePort, LOW);
}

void turnAllLowerResistancesOn() {
    turnResistanceOn(R1);
    turnResistanceOn(R2);
    turnResistanceOn(R3);
    turnResistanceOn(R4);
}

void turnAllLowerResistancesOff() {
    turnResistanceOff(R1);
    turnResistanceOff(R2);
    turnResistanceOff(R3);
    turnResistanceOff(R4);
}

void turnAllUpperResistancesOn() {
    turnResistanceOn(R5);
}

void turnAllUpperResistancesOff() {
    turnResistanceOff(R5);
}

void turnAllResistancesOn() {
    turnAllLowerResistancesOn();
    turnAllUpperResistancesOn();
}

void turnAllResistancesOff() {
    turnAllLowerResistancesOff();
    turnAllUpperResistancesOff();
}

int boolToBin(bool b) {
  return b ? 1 : 0;
}

void sendDataToComputer(const PinData& data, int tt) {
    Serial.print(data.controlTemperature);
    Serial.print("|");
    Serial.print(data.lowerProbeTemperature);
    Serial.print("|");
    Serial.print(tt);
    Serial.print("|");
    Serial.print(boolToBin(data.lowerResistancesAreTurnedOn[0]));
    Serial.print("|");
    Serial.print(boolToBin(data.lowerResistancesAreTurnedOn[1]));
    Serial.print("|");
    Serial.print(boolToBin(data.lowerResistancesAreTurnedOn[2]));
    Serial.print("|");
    Serial.print(boolToBin(data.lowerResistancesAreTurnedOn[3]));
    Serial.print("|");
    Serial.print(boolToBin(data.upperResistanceIsTurnedOn));
    Serial.print("|");
    Serial.print(boolToBin(data.upperFanIsTurnedOn));
    Serial.print("|");
    Serial.print(boolToBin(data.lowerFanIsTurnedOn));
    Serial.print("|00");
    Serial.println("");
}

PinData readDataFromPins() {
    PinData data;
    
    data.upperFanIsTurnedOn = digitalRead(F1);
    data.lowerFanIsTurnedOn = digitalRead(F2);
    data.lowerResistancesAreTurnedOn[0] = digitalRead(R1);
    data.lowerResistancesAreTurnedOn[1] = digitalRead(R2);
    data.lowerResistancesAreTurnedOn[2] = digitalRead(R3);
    data.lowerResistancesAreTurnedOn[3] = digitalRead(R4);
    data.upperResistanceIsTurnedOn = digitalRead(R5);
    
    data.controlTemperature = controlThermocouple.readCelsius();
    data.lowerProbeTemperature = lowerThermocouple.readCelsius();
    data.upperProbeTemperature = upperThermocouple.readCelsius();
    
    return data;
}

String readStringFromPC() {
    String result = "";
    
    while (Serial.available()) {
        delay(3); /*delay to allow buffer to fill*/
        if (Serial.available( )) {
            char c = Serial.read(); /*gets one byte from serial buffer*/
            result += c; /*makes the string result*/
        }
    }
    
    return result;
}

void pauseReballing() {
    pausedState = currentState;
    pauseStartTime = millis();
    currentState = State::PAUSED_FANS_ON;
}

void unpauseReballing() {
    currentState = State::PREHEAT;
    currentStateStartTime += millis() - pauseStartTime; // Hacky way to get the time to resume normally.
    pauseStartTime = 0;
}

// https://arduino.stackexchange.com/a/1237
String getValue(String data, char separator, int index)
{
    int found = 0;
    int strIndex[] = { 0, -1 };
    int maxIndex = data.length() - 1;

    for (int i = 0; i <= maxIndex && found <= index; i++) {
        if (data.charAt(i) == separator || i == maxIndex) {
            found++;
            strIndex[0] = strIndex[1] + 1;
            strIndex[1] = (i == maxIndex) ? i+1 : i;
        }
    }
    return found > index ? data.substring(strIndex[0], strIndex[1]) : "";
}

void readDataFromPC() {
    String message = readStringFromPC();
    
    if (message.length() > 0) {
        //Serial.read(); // Needed?
        int messageFromPC = message.toInt();

        if (messageFromPC == START_BUTTON_PRESSED) {
            if(currentState == State::PAUSED_FANS_ON || currentState == State::PAUSED_FANS_OFF) {
                unpauseReballing();
            } else {
                currentState = State::PREHEAT;
                currentStateStartTime = millis();
            }
        } else if (messageFromPC == STOP_BUTTON_PRESSED) {
            currentState = State::FINISHED;
        } else if (messageFromPC == PAUSE_BUTTON_PRESSED) {
            pauseReballing();
        }

		chipConfigurationData.soakTemperature = getValue(message, ',', 0).toInt();
		chipConfigurationData.reflowTemperature = getValue(message, ',', 1).toInt();
		chipConfigurationData.damageTemperarure = getValue(message, ',', 2).toInt();
		chipConfigurationData.preheatDuration = getValue(message, ',', 3).toInt();
		chipConfigurationData.soakDuration = getValue(message, ',', 4).toInt();
		chipConfigurationData.reflowDuration = getValue(message, ',', 5).toInt();
		chipConfigurationData.coolingDuration = getValue(message, ',', 6).toInt();
		chipConfigurationData.isValid = true;
    }
}

double getStatePercentage(int startTime, int stateDuration) {
    return (double) (millis() - startTime) / stateDuration;
}

int getStateTemperature(int startTime, int stateDuration, int initialTemperature, int finalTemperature) {
    double statePercentage = getStatePercentage(startTime, stateDuration);
    return (int) (statePercentage * finalTemperature + (1 - statePercentage) * initialTemperature);
}

void doNormalStateUpdate(int initialTemperature, int finalTemperature, int stateDuration, State nextState, const PinData& pinData) {
    int targetTemperature = getStateTemperature(currentStateStartTime, stateDuration, initialTemperature, finalTemperature);
    
    if(pinData.controlTemperature < targetTemperature) {
        turnAllFansOff();
        turnAllResistancesOn();
    } else {
        turnAllFansOn();
        turnAllResistancesOff();
    }
    
    if(pinData.controlTemperature > chipConfigurationData.damageTemperarure) {
        turnAllFansOn();
        turnAllResistancesOff();
    }
    
    if(millis() > currentStateStartTime + stateDuration) {
        currentState = nextState;
        currentStateStartTime = millis();
    }
    
    sendDataToComputer(pinData, targetTemperature);
}

void setup() {
    Serial.begin(SERIAL_DATA_RATE);
    delay(100);
    
    pinMode(R1, OUTPUT);
    pinMode(R2, OUTPUT);
    pinMode(R3, OUTPUT);
    pinMode(R4, OUTPUT);
    pinMode(R5, OUTPUT);
    pinMode(F1, OUTPUT);
    pinMode(F2, OUTPUT);
    
    turnAllResistancesOff();
    turnAllFansOff();
}

void loop() {
    const PinData pinData = readDataFromPins();

    switch(currentState) {
        case State::NOT_STARTED: {
            break;
        }
        
        case State::PAUSED_FANS_ON: {
            turnAllResistancesOff();
            turnAllFansOn();
            if(millis() > pauseStartTime + PAUSE_FAN_DURATION) currentState = State::PAUSED_FANS_OFF;
            sendDataToComputer(pinData, 0);
            break;
        }
        
        case State::PAUSED_FANS_OFF: {
            turnAllFansOff();
            sendDataToComputer(pinData, 0);
            break;
        }
        
        case State::PREHEAT: {
            doNormalStateUpdate(ROOM_TEMPERATURE, chipConfigurationData.soakTemperature, chipConfigurationData.preheatDuration, State::SOAK, pinData);
            break;
        }
        
        case State::SOAK: {
            doNormalStateUpdate(chipConfigurationData.soakTemperature, chipConfigurationData.soakTemperature, chipConfigurationData.soakDuration, State::REFLOW, pinData);
            break;
        }
        
        case State::REFLOW: {
            doNormalStateUpdate(chipConfigurationData.reflowTemperature, chipConfigurationData.reflowTemperature, chipConfigurationData.reflowDuration, State::COOLING, pinData);
            break;
        }
        
        case State::COOLING: {
            doNormalStateUpdate(chipConfigurationData.reflowTemperature, ROOM_TEMPERATURE, chipConfigurationData.coolingDuration, State::FINISHED, pinData);
            break;
        }
        
        case State::FINISHED: {
            turnAllResistancesOff();
            turnAllFansOff();
        }
    }
    
    readDataFromPC();
    delay(UPDATE_DELAY_DURATION);
}
