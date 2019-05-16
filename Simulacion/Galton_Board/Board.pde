static int size = 10, Pels = 100, cont = 0, cont2 = 0;
FCircle[] Poste = new FCircle[55];
FCircle[] Poste2 = new FCircle[55];
FCircle[] Balls = new FCircle[Pels];

void board(){
 int i, j ,x, y, x1, y1; 
 for(i=0; i<55; i++){
  Poste[i] = new FCircle(10);
  Poste[i].setStatic(true);
 }
 for(i=0; i<55; i++){
  Poste2[i] = new FCircle(10);
  Poste2[i].setStatic(true);
 }
 
 x = width/2;
 y = 30;
 x1 = x;
 y1 = y;
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
}

void BallDrop(){
 int i;
 for(i=0; i<Pels; i++){
  Balls[i] = new FCircle(10);
  Balls[i].setPosition((width/2)+random(10),(i*0.1));
  Balls[i].setFill(random(255),random(255),random(255));
  Mundo.add(Balls[i]);
 }
}
