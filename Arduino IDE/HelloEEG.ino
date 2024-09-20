const int ledPin = 7; //Sesuaikan Pin 
int receivedValue = 0; //Sesuaikan Pin 

void setup() {
  pinMode(ledPin, OUTPUT);
  Serial.begin(115200);
}

void loop() {
  if (Serial.available() > 0) {
    String input = Serial.readStringUntil(';');
    input.trim(); 
    if (input.length() > 0) {
      receivedValue = input.toInt();
      Serial.println("Nilai Diterima: " + String(receivedValue));

      if (receivedValue > 70) { // //Sesuaikan pada Nilai Berapa Lampu Hidup/Mati
        digitalWrite(ledPin, HIGH);
        Serial.println("LED ON");
      } else {
        digitalWrite(ledPin, LOW);
        Serial.println("LED OFF");
      }
    }
  }
}
