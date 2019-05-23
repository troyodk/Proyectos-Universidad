import fisica.*;

FWorld Mundo;
FBox Limit1;
PImage img;
int count=0;

void setup(){
 img = loadImage("BGhere3.jpg");//plx never press 'p', if u press 'p', u can press 's' ;
 size(700,700);
 Fisica.init(this);
 Mundo = new FWorld(); 
 Mundo.add(Limit1);
 
 board();
 
 Mundo.setEdges();
 Mundo.setEdgesFriction(.5);
 Mundo.setEdgesRestitution(0);
}

void draw(){
   if (count==0){
     background(255);
   }
   else
   {
      background(img);
   }
 //background(random(255),random(255),random(255));
   Mundo.step();
   Mundo.draw();
}

void mouseClicked(){
 BallDrop(); 
}

void keyPressed(){
  if(key=='p' || key=='P'){
    count=1;
 }else if(key=='s'|| key=='S'){
 count=0;
 }
 
  if(key=='c' || key=='C'){
    ClearDaBalls();
  }
  
}
