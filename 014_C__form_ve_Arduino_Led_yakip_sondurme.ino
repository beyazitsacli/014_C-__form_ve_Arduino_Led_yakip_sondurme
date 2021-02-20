
// C# Form ile Arduinoda Led Yakip Sondurmek
    int LED_Pin=2;
    
    void setup()
  {
    Serial.begin(9600);
    pinMode(LED_Pin,OUTPUT);
  }
  
  
    void loop() 
  {
  char gelen_bilgi=Serial.read();
    if(gelen_bilgi=='1')
  {
    digitalWrite(LED_Pin,HIGH);
  }
  
    if(gelen_bilgi=='0')
  {
    digitalWrite(LED_Pin,LOW);
  }
  
  delay(100);
  }
