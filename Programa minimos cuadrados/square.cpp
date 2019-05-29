#include <stdlib.h>
#include <math.h>
#include<stdio.h>
#include<iostream>
using namespace std;


int linreg(int n, const double x[], const double y[], double* caida, double* intercepcion, double* correlacion){
    double   sumx = 0.0;
    double   sumx2 = 0.0;
    double   sumxy = 0.0;
    double   sumy = 0.0;
    double   sumy2 = 0.0;

    for (int i=0;i<n;i++){
        sumx  += x[i];
        sumx2 += (x[i]*x[i]);
        sumxy += x[i] * y[i];
        sumy  += y[i];
        sumy2 += (y[i]*y[i]);
    }

    double denom = (n * sumx2 - (sumx*sumx));
    if (denom == 0) ///verifica si es valido
        {
        *caida = 0;
        *intercepcion = 0;
        if (correlacion) *correlacion = 0;
            return 1;
    }

    *caida = (n * sumxy  -  sumx * sumy) / denom;
    *intercepcion = (sumy * sumx2  -  sumx * sumxy) / denom;
    if (correlacion!=NULL) {
        *correlacion = (sumxy - sumx * sumy / n) /
              sqrt((sumx2 - (sumx*sumx)/n) *
              (sumy2 - (sumy*sumy)/n));
    }

    return 0;
}
int main()
{
    //freopen("datos.txt","r",stdin);
    int n ;
   double x[200];
    double y[200];
    cin>>n;
    for(int i=0;i<n;i++)
    {
        cin>>x[i]>>y[i];
    }
    double caida,intercepcion,correlacion;
    linreg(n,x,y,&caida,&intercepcion,&correlacion);
    cout<<"su correlacion es de "<<correlacion<<" y la formula de la y es y="<<caida<<"x + "<<intercepcion;
    return 0;
}
