import fisica.*;

FWorld Mundo;
FBox Caja;
FBox Caja2;
FCircle Circulo;

void setup(){
 size(500,500);
 background(0);
 Fisica.init(this);
 Mundo = new FWorld();
 
 //Caja = new FBox(40,40);
 //Caja.setFill(255,0,0);
 //Caja.setPosition(200,0);
 
 //Caja2 = new FBox(100,30);
 //Caja2.setFill(0,255,0);
 //Caja2.setPosition(240,400);
 //Caja2.setStatic(true);
 
 //Circulo = new FCircle(40);
 //Circulo.setPosition(300,0);
 
 //Mundo.add(Caja);
 //Mundo.add(Caja2);
 //Mundo.add(Circulo);
 
 board();
 
 Mundo.setEdges();
 Mundo.setEdgesFriction(1);
 Mundo.setEdgesRestitution(1);
}

void draw(){
 background(0);
 Mundo.step();
 Mundo.draw();
}

void mouseClicked(){
 BallDrop(); 
}

void keyPressed(){
 ClearDaBalls();
}
