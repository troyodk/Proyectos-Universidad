static int size = 12, Pels = 150, cont = 0;
FCircle[] Poste = new FCircle[78];
FCircle[] Balls = new FCircle[Pels];
FLine[] Limite_Bars= new FLine[30];

void board(){
 int i, j ,x, y; 
 for(i=0; i<78; i++){
  Poste[i] = new FCircle(10);
  Poste[i].setStatic(true);
 }

 x = width/2;
 y = 80;
 int lol=0;
 for(i = 1; i <= size; i++){
    
    for (j = 0; j < i; j++){
        Poste[cont].setPosition(x+(20*j)-lol,y);  
        Mundo.add(Poste[cont]);
        cont ++;
    }
   
    lol-=10;
    x = width/2;;
    x = x-(20*i);
    y += 20;
 }
   FLine troy=new FLine(340,50,240,300);
   FLine troy2=new FLine(455,300,360,50);
   //troy.setDensity(100);
   Mundo.add(troy);
   Mundo.add(troy2);
 
 //for(i = 1; i <= size; i++){  
 //   x1 = width/2;
 //   for (j = 0; j < i; j++){
 //       Poste2[cont2].setPosition(x1,y1);
 //       Mundo.add(Poste2[cont2]);
 //       x1 += 20;
 //       cont2 ++;
 //   }
 //   x1 -= 20*i;
 //   y1 += 20;
 //}
 
 //Poste[0].setPosition(x,y);
 //Mundo.add(Poste[0]);
 
 //Poste[1].setPosition(x-15,y+15);
 //Mundo.add(Poste[1]);
 //Poste[2].setPosition(x+15,y+15);
 //Mundo.add(Poste[1]);
 
 for( i=0;i<30;i++)
      {
        /*
        for(j=0;j<30;j++)
        {
           FCircle lax=new FCircle(10);
           lax.setStatic(true);
           lax.setPosition(i*30,500+(j*10));
           Mundo.add(lax);
        }
        */
        FBox pendejada= new FBox(10,500);
        pendejada.setPosition((i*30),(600));
        pendejada.setStatic(true);
        Mundo.add(pendejada);
        /*
      Limite_Bars[i]= new FLine(0,0,0,500);
      Limite_Bars[i].setPosition((i*30),(500));
      Limite_Bars[i].setStroke(random(255),random(255),random(255));
      Limite_Bars[i].setStatic(true);
      Mundo.add(Limite_Bars[i]);
      */
      }
}

void BallDrop(){
 int i=0;
 /*
 for(i=0; i<Pels; i++){
  Balls[i] = new FCircle(10);
  Balls[i].setPosition((width/2)+random(10),(i*-.1));
  Balls[i].setFill(random(255),random(255),random(255));
  Mundo.add(Balls[i]);
 }
 */
  Balls[i] = new FCircle(10);
  Balls[i].setPosition((width/2)+random(10),(i*-.1));
  Balls[i].setFill(random(255),random(255),random(255));
  Balls[i].setDensity(100);
  Mundo.add(Balls[i]);
 
}
 
void ClearDaBalls(){
  int i;
  for(i=0; i<Pels; i++){
  //Balls[i] = new FCircle(10);
  //Balls[i].setPosition((width/2)+random(10),(i*0.1));
  //Balls[i].setFill(random(255),random(255),random(255));
    Balls[i].removeFromWorld();
 }
}
