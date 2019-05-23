static int size = 12, Pels = 50, cont = 0;
FCircle[] Poste = new FCircle[78];
FCircle[] Balls = new FCircle[Pels];
FLine[] Limite_Bars= new FLine[30];

void board(){
 int i, j ,x, y; 
 for(i=0; i<78; i++){
  Poste[i] = new FCircle(10);
  Poste[i].setStatic(true);
  Poste[i].setFill(255,random(255),random(255),random(90,150));
 }

 x = width/2;
 y = 80;
 int lol=0;
 for(i = 1; i <= size; i++){
    
    for (j = 0; j < i; j++){
      if(i!=1)
      {
        Poste[cont].setPosition(x+(20*j)-lol,y);  
        Mundo.add(Poste[cont]);
      }
        if(j+1==-1)
        {
     System.out.print(x+(20*j)-lol);
     System.out.print(" ");
     System.out.print(y);
     System.out.print(" ");
        }
        cont ++;
    }
     
    lol-=15;
    x-=25;
    y += 20;
 }
   stroke(255,0,0);
   FLine troy=new FLine(330,75,222,310);
   troy.setStroke(255,0,random(255),50);
   FLine troy2=new FLine(476,310,365,75);
   troy2.setStroke(255,0,0,50);
   
   
        FBox cosas= new FBox(10,120);
        cosas.setPosition(415,(24));
        cosas.setStatic(true);
        cosas.setRotatable(true);
        cosas.setRotation(5*PI/16);
        cosas.setFill(255,0,0,80);

        
        FBox cosas2= new FBox(10,120);
        cosas2.setPosition(284,(24));
        cosas2.setStatic(true);
        cosas.setRotatable(true);
        cosas2.setRotation(-5*PI/16);
        cosas2.setFill(255,0,0,80);

        FBox cosos = new FBox(8,60);
        cosos.setPosition(320,(80));
        cosos.setStatic(true);
        cosos.setRotatable(true);
        cosos.setRotation(-4*PI/16);
        cosos.setFill(255,0,0,80);

        FBox cosos2 = new FBox(8,60);
        cosos2.setPosition(380,(80));
        cosos2.setStatic(true);
        cosos2.setRotatable(true);
        cosos2.setRotation(4*PI/16);
        cosos2.setFill(255,0,0,80);

       
        Mundo.add(cosas);
        Mundo.add(cosas2);
        Mundo.add(cosos);
        Mundo.add(cosos2);
      
   Mundo.add(troy);
   Mundo.add(troy2);
 
 for( i=0;i<30;i++)
      {
        FBox cosa= new FBox(6,320);
        cosa.setPosition((i*25),(600));
        cosa.setStatic(true);
        cosa.setFill(random(255),random(255),random(255),150);
        Mundo.add(cosa);
      }
}

void BallDrop(){
 int i=0;
 
 for(i=0; i<Pels; i++){
  Balls[i] = new FCircle(6.9f);
  Balls[i].setDensity(.5);
  Balls[i].setPosition((width/2)+random(5),(0));
  Balls[i].setFill(random(255),random(255),random(255),150);
  Balls[i].setDensity(100);
  Mundo.add(Balls[i]);
 }
  
}
 
void ClearDaBalls(){
  int i;
  for(i=0; i<Pels; i++){
    Balls[i].removeFromWorld();
 }
}
