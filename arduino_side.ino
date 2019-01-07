#include <MAX6675_Thermocouple.h>
#define DEBUG(a) Serial.println(a);

int periodo = 5000;
int periodo1 = 500;
int periodo2 = 500;
byte dato;
bool paso;
bool paso1;
bool paso2;
byte paso3 = 1;
byte paso5 = 1;
byte paso6 = 0;
byte paso4 = 0;
byte paso7 = 1;
byte paso8 = 0;
byte paso9 = 1;
byte paso10 = 0;
byte paso11 = 1;
byte paso12 = 0;
unsigned long tiempoAnterior = 0;
unsigned long tiempoAnterior1 = 0;//guarda tiempo de referencia para comparar
unsigned long tiempoAnterior2 = 0;//guarda tiempo de referencia para comparar
int i;
int PosicionComa;
int LargoMens;
String Mensaje;
int estado;
int estado1;
String readString;
String T1;
String T2;
String T3;
int T11;
int T21;
int T31;

String temp1;
String temp2;
String temp3;
String temp4;
String tiempo1;
String tiempo2;
int temper1;
int temper2;
int temper3;
int temper4;
int tiempo11;
int tiempo12;
int ktcDO = 5;   // SO
int ktcCS = 6;   // CS
int ktcCLK = 7;  // SCK
int ktc2DO = 8;   // SO
int ktc2CS = 9;   // CS
int ktc2CLK = 10;  // SCK
int ktc3DO = 11;   // SO
int ktc3CS = 12;   // CS
int ktc3CLK = 13;  // SCK

int R1 = 22;
int R2 = 23;
int R3 = 24;
int R4 = 25;
int R5 = 26;
int R6 = 27;
int V1 = 28;
int V2 = 29;
String R11;
String R21;
String R31;
String R41;
String R51;
String R61;
String V11;
String V21;

MAX6675_Thermocouple ktc(ktcCLK, ktcCS, ktcDO);
MAX6675_Thermocouple ktc2(ktc2CLK, ktc2CS, ktc2DO);
MAX6675_Thermocouple ktc3(ktc3CLK, ktc3CS, ktc3DO);

void turnFanOn(int fanPort) {
    digitalWrite(resistancePort, fanPort);
}

void turnFanOff(int fanPort) {
    digitalWrite(resistancePort, fanPort);
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

void sendDataToComputer() {
    Serial.print(T1);
    Serial.print("|");
    Serial.print(T2);
    Serial.print("|");
    Serial.print(T3);
    Serial.print("|");
    Serial.print(R11);
    Serial.print("|");
    Serial.print(R21);
    Serial.print("|");
    Serial.print(R31);
    Serial.print("|");
    Serial.print(R41);
    Serial.print("|");
    Serial.print(R51);
    Serial.print("|");
    Serial.print(R61);
    Serial.print("|");
    Serial.print(V11);
    Serial.print("|");
    Serial.print(V21);
    Serial.print("|");
    Serial.print(tiempo11);
    Serial.print("|");
    Serial.print(tiempo12);
    Serial.print("|");
    Serial.print("00");
    Serial.println("");
}

readDataFromReballingMachine() {
    while (Serial.available()) {
        delay(3); /*delay to allow buffer to fill*/
        if (Serial.available( )) {
            char c = Serial.read(); /*gets one byte from serial buffer*/
            readString += c; /*makes the string readString*/
        }
    }
    
    if (readString.length() > 0) {
        estado1 = Serial.read();
        int estado2 = readString.toInt();

        Mensaje = readString;

        readString = "";

        if (estado2 == 7) {
            paso = true;
            paso2 = false;
            paso3 = 1;
        } else if (estado2 == 8) {
            paso = false;
            paso2 = false;
        } else if (estado2 == 9) {
            paso2= true;
        }

        PosicionComa = Mensaje.indexOf (',');
        LargoMens = Mensaje.length();

        if (PosicionComa != -1) {
            temp1 = (Mensaje.substring(0,PosicionComa));
            Mensaje = Mensaje.substring(PosicionComa+1, Mensaje.length());
            temp2 = (Mensaje.substring(0,PosicionComa));
            Mensaje = Mensaje.substring(PosicionComa+1, Mensaje.length());
            temp3 = (Mensaje.substring(0,PosicionComa));
            Mensaje = Mensaje.substring(PosicionComa+1, Mensaje.length());
            temp4 = (Mensaje.substring(0,PosicionComa));
            Mensaje = Mensaje.substring(PosicionComa+1, Mensaje.length());
            tiempo1 = (Mensaje.substring(0,PosicionComa));
            Mensaje = Mensaje.substring(PosicionComa+1, Mensaje.length());
            tiempo2 = (Mensaje.substring(0,PosicionComa));
        }

        temper1= temp1.toInt();  
        temper2= temp2.toInt(); 
        temper3= temp3.toInt(); 
        temper4= temp4.toInt();
        tiempo11= tiempo1.toInt();
        tiempo12= tiempo2.toInt();
    }
}

void setup() {
    // put your setup code here, to run once:
    Serial.begin(9600);
    delay (100);
    paso = false;
    paso1 = true;
    paso2 = false;
    paso5 = 1;
    pinMode(R1,OUTPUT);
    pinMode(R2,OUTPUT);
    pinMode(R3,OUTPUT);
    pinMode(R4,OUTPUT);
    pinMode(R5,OUTPUT);
    pinMode(R6,OUTPUT);
    pinMode(V1,OUTPUT);
    pinMode(V2,OUTPUT);
    
    turnAllResistancesOff();
    turnAllFansOff();
}

void loop() {
    // put your main code here, to run repeatedly:
    // estado = Serial.read();
  
    if (paso == true){
        //Arranque de resistencias
        if (paso1 == true){ //para poder apagar las resistencias
            turnAllResistancesOff();
            turnAllFansOff();
        }

        T1 =String(ktc.readCelsius());
        T2 =String(ktc2.readCelsius()); 
        T3 =String(ktc3.readCelsius());
        R11=digitalRead(R1);
        R21=digitalRead(R2);
        R31=digitalRead(R3);
        R41=digitalRead(R4);
        R51=digitalRead(R5);
        R61=digitalRead(R6);
        V11=digitalRead(V1);
        V21=digitalRead(V2);

        T11= ktc.readCelsius();
        T21= ktc2.readCelsius();
        paso1 = false;

        delay(1000);
        
        if (T11>(temper1-2)){
            turnAllResistancesOff();
            paso5=0; // Primer paso en temp
        }
    
        if (T11<temper1){
            turnAllResistancesOn();
        }
        
        if (T11<(temper2+1) && paso5==0){
            turnResistanceOff(R1);
            turnResistanceOff(R4);
            turnResistanceOn(R2);
            turnResistanceOn(R3);
            turnAllUpperResistancesOn();
        }
        
        //  if (temper3< T11 >(temper2+1)){ //Tiempo Pausa tiempo11
        if ((T11>temper2)&&paso7 == 1){
            periodo1 = tiempo11*50;
            tiempoAnterior1 = millis();
            paso8 = 1;   
            turnAllUpperResistancesOff();
            paso7 = 0;  //desactivo pausa  
        }
        
        if((millis()>tiempoAnterior1+periodo1)&&paso8 == 1){  //si ha transcurrido el periodo programado
            paso8 = 0;  //y desactivo el temporizador
            tiempoAnterior1 = 0; 
            paso6=1;  
        }
        
        if (T11<(temper3+1)&& paso6 == 1){
            turnAllUpperResistancesOn();
            //paso6 = 0;
        }
        
        //  if (temper4< T11 >(temper2+1)){ //Tiempo Pausa tiempo12
        if ((T11>temper4)&&paso9 == 1){
            periodo2 = tiempo12*50;
            tiempoAnterior2 = millis();
            paso10 = 1;
            turnAllUpperResistancesOff();
            paso9 = 0;  //desactivo pausa  
        }
        
        if((millis()>tiempoAnterior2+periodo2)&&paso10 == 1){  //si ha transcurrido el periodo programado
            paso10 = 0;  //y desactivo el temporizador
            tiempoAnterior2 = 0; 
            paso6=1;  
        }
        
        //if (T11<(temper4+1)&& paso6 == 1){
        // digitalWrite(R5,HIGH);
        // digitalWrite(R6,HIGH);
        // }
     
        sendDataToComputer();
        
        if (paso2 == true) {   //boton de pausa
            turnAllResistancesOff();
            //periodo = tiempo11*3;
            if (paso3 == 1){
                tiempoAnterior = millis();
                paso4 = 1;     
                turnAllFansOn();
                paso3 = 0;  //desactivo pausa  
            }
            if((millis()>tiempoAnterior+periodo)&&paso4 == 1){  //si ha transcurrido el periodo programado
                paso4 = 0;  //y desactivo el temporizador
                tiempoAnterior = 0;
                turnAllFansOff();
                paso5=1;
            }
        }
    } else {
        delay (500);
        turnAllResistancesOff();
    }

    readDataFromReballingMachine();
}
