Random ataque = new Random();

int heroe = 10;
int monstruo = 10;

int turno = 0;
int damage = 0;

while(heroe > 0 && monstruo > 0){
    damage = ataque.Next(1,10);
    if(turno % 2 == 0){
        monstruo -= damage;
        if(monstruo < 0) monstruo = 0;
        
        Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monstruo} health.");
        turno ++;
    }
    else{
        heroe -= damage;
        if(heroe < 0) heroe = 0;
        
        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroe} health.");
        turno ++;
    }
}

if (monstruo == 0){
    Console.WriteLine("Hero wins!");
}
else{
    Console.WriteLine("Monster wins!");
}