//declaração de variáveis
int vermelho = 7;
int amarelo = 6;
int verde = 5;

void setup() { 
pinMode(vermelho, OUTPUT);
pinMode(amarelo, OUTPUT);
pinMode(verde, OUTPUT);
}

void loop() {
digitalWrite(vermelho, HIGH); //led vermelho aceso
digitalWrite(amarelo, LOW); //led apagado      
digitalWrite(verde, LOW); //led apagado
delay(2000);   

digitalWrite(vermelho, LOW); //led apagado
digitalWrite(amarelo, LOW); //led apagado           
digitalWrite(verde, HIGH); //led verde aceso
delay(2000); 
  
digitalWrite(vermelho, LOW); //led apagado
digitalWrite(amarelo, HIGH); //led amarelo aceso        
digitalWrite(verde, LOW); //led apagado
delay(2000); 
}