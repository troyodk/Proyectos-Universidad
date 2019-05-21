static int size = 12, Pels = 4, cont = 0;
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
   FLine troy=new FLine(345,50,240,300);
   FLine troy2=new FLine(460,300,355,50);
   
   
    FBox pendejadas= new FBox(10,80);
        pendejadas.setPosition(367,(55));
        pendejadas.setStatic(true);
        Mundo.add(pendejadas);
        FBox pendejadas2= new FBox(10,80);
        pendejadas2.setPosition(332,(55));
        pendejadas2.setStatic(true);
        Mundo.add(pendejadas2);
  // FLine limit_sup=new FLine(345,70,345,100);
   //troy.setDensity(100);
   
   Mundo.add(troy);
   Mundo.add(troy2);
   //Mundo.add(limit_sup);
 
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
 
 for(i=0; i<Pels; i++){
   Balls[i] = new FCircle(7);
 // System.out.print( Balls[i].getDensity());
  Balls[i].setDensity(.5);
  Balls[i].setPosition((width/2)+random(10),(0));
  Balls[i].setFill(random(255),random(255),random(255));
  Balls[i].setDensity(100);
  Mundo.add(Balls[i]);
 }
 
 
 
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
