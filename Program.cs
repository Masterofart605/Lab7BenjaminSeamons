DriverProgram();



void DriverProgram(){
Console.Clear();
int firstChoise;
int input;
int secondChoise;
while(true){
    try{
        Console.WriteLine("What would you like to calculate? \n 0:Tempeture \n 1:Distance \n 2:Time");
        firstChoise = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What in the number?");
        input = Convert.ToInt32(Console.ReadLine());
        if(firstChoise < 2 || firstChoise > 0){
            break;
        }else{
            Console.WriteLine("Please input a apropreate value.");
        }
    }catch{
        Console.WriteLine("Please input a apropreate value.");
    }
}
while(true){
    try{
        if(firstChoise==0){
            Console.WriteLine("What is the original Tempeture? \n 0:Celcius \n 1:Fahrenheit \n 2:Kelvin");
            secondChoise = Convert.ToInt32(Console.ReadLine());
            temepture temp = (temepture)secondChoise;
            if(temp == temepture.Celcius){
                Console.WriteLine($"{CelciusToKF(input,temp)}");
            }else if(temp == temepture.Fahrenheit){
                Console.WriteLine($"{FahrenheitToCK(input,temp)}");
            }else{
                Console.WriteLine($"{KelvinToCF(input,temp)}");
            }
            break;

        }else if(firstChoise == 1){
            Console.WriteLine("What is the original Distance? \n 0:Inches \n 1:Feet \n 2:Yards");
            secondChoise = Convert.ToInt32(Console.ReadLine());
            length longht = (length)secondChoise;
            if(longht == length.inches){
                Console.WriteLine($"{InchToFY(input,longht)}");
            }else if(longht == length.feet){
                Console.WriteLine($"{FeetToInY(input,longht)}"); 
            }else{
                Console.WriteLine($"{YardToInF(input,longht)}");
            }
            break;
        }else{
            Console.WriteLine("What is the original Time? \n 0:Seconds \n 1:Minutes \n 2:Hours");
            secondChoise = Convert.ToInt32(Console.ReadLine());
            time timeStuff = (time)secondChoise;
            if(timeStuff == time.seconds){
                Console.WriteLine($"{SecondsToMH(input,timeStuff)}");
            }else if(timeStuff == time.minutes){
                Console.WriteLine($"{MinutesToSH(input,timeStuff)}");
            }else{
                Console.WriteLine($"{HoursToSM(input,timeStuff)}");
            }
            break;
        }
    }catch{
        Console.WriteLine("Please input 0, 1, or 2 for the apropreate mesurement");
    }
}
}

//temp
(double, temepture) CelciusToKF(double input, temepture temp){
double zeroOrOne;
double output;
while(true){
    try{
        Console.WriteLine("What would you like to convert the tempeture too? \n 0:Fahrenheit \n 1:Kelvin");
        zeroOrOne = Convert.ToInt32( Console.ReadLine());
        break;
    }catch{
        Console.WriteLine("Please choose 0 or 1.");
    }
}
if (zeroOrOne == 0){
    output = (input*(9/5))+32;
    temp = temepture.Fahrenheit;
}else{
    output = input + 273.15;
    temp = temepture.Kelvin;
}
    return(output,temp);
}

(double, temepture) FahrenheitToCK(double input, temepture temp){
double zeroOrOne;
double output;
while(true){
    try{
        Console.WriteLine("What would you like to convert the tempeture too? \n 0:Celcius \n 1:Kelvin");
        zeroOrOne = Convert.ToInt32( Console.ReadLine());
        break;
    }catch{
        Console.WriteLine("Please choose 0 or 1.");
    }
}
if (zeroOrOne == 0){
    output = (input-32)*(5/9);
    temp = temepture.Celcius;
}else{
    output = ((input - 32)*(5/9))+273.15;
    temp = temepture.Kelvin;
}
    return(output,temp);
}

(double, temepture) KelvinToCF(double input, temepture temp){
double zeroOrOne;
double output;
while(true){
    try{
        Console.WriteLine("What would you like to convert the tempeture too? \n 0:Celcius \n 1:Fahrenheit");
        zeroOrOne = Convert.ToInt32( Console.ReadLine());
        break;
    }catch{
        Console.WriteLine("Please choose 0 or 1.");
    }
}
if (zeroOrOne == 0){
    output = input-273.15;
    temp = temepture.Celcius;
}else{
    output = ((input - 273.15)*(9/5))+32;
    temp = temepture.Fahrenheit;
}
    return(output,temp);
}
//distance
(double, length) InchToFY(double input, length longth){
double zeroOrOne;
double output;
while(true){
    try{
        Console.WriteLine("What would you like to convert the distance too? \n 0:Feet \n 1:Yards");
        zeroOrOne = Convert.ToInt32(Console.ReadLine());
        break;
    }catch{
        Console.WriteLine("Please choose 0 or 1.");
    }
}
if (zeroOrOne == 0){
    output = input/12;
    longth = length.feet;
}else{
    output = input/36;
    longth = length.yard;
}
    return(output,longth);
}

(double, length) FeetToInY(double input, length longth){
double zeroOrOne;
double output;
while(true){
    try{
        Console.WriteLine("What would you like to convert the distance too? \n 0:Inches \n 1:Yards");
        zeroOrOne = Convert.ToInt32(Console.ReadLine());
        break;
    }catch{
        Console.WriteLine("Please choose 0 or 1.");
    }
}
if (zeroOrOne == 0){
    output = input*12;
    longth = length.inches;
}else{
    output = input/3;
    longth = length.yard;
}
    return(output,longth);
}

(double, length) YardToInF(double input, length longth){
double zeroOrOne;
double output;
while(true){
    try{
        Console.WriteLine("What would you like to convert the distance too? \n 0:Inches \n 1:Feet");
        zeroOrOne = Convert.ToInt32(Console.ReadLine());
        break;
    }catch{
        Console.WriteLine("Please choose 0 or 1.");
    }
}
if (zeroOrOne == 0){
    output = input*36;
    longth = length.inches;
}else{
    output = input*3;
    longth = length.feet;
}
    return(output,longth);
}
//time
(double, time) SecondsToMH(double input, time timeStuff){
double zeroOrOne;
double output;
while(true){
    try{
        Console.WriteLine($"What would you like to convert {input} {timeStuff} time too? \n 0:Minutes \n 1:Hours");
        zeroOrOne = Convert.ToInt32(Console.ReadLine());
        break;
    }catch{
        Console.WriteLine("Please choose 0 or 1.");
    }
}
if (zeroOrOne == 0){
    output = input/60;
    timeStuff = time.minutes;
}else{
    output = (input/60)/60;
    timeStuff = time.hours;
}
    return(output,timeStuff);
}

(double, time) MinutesToSH(double input, time timeStuff){
double zeroOrOne;
double output;
while(true){
    try{
        Console.WriteLine($"What would you like to convert {input} {timeStuff} time too? \n 0:Seconds \n 1:Hours");
        zeroOrOne = Convert.ToInt32(Console.ReadLine());
        break;
    }catch{
        Console.WriteLine("Please choose 0 or 1.");
    }
}
if (zeroOrOne == 0){
    output = input*60;
    timeStuff = time.seconds;
}else{
    output = input/60;
    timeStuff = time.hours;
}
    return(output,timeStuff);
}

(double, time) HoursToSM(double input, time timeStuff){
double zeroOrOne;
double output;
while(true){
    try{
        Console.WriteLine($"What would you like to convert {input} {timeStuff} time too? \n 0:Seconds \n 1:Minutes");
        zeroOrOne = Convert.ToInt32(Console.ReadLine());
        break;
    }catch{
        Console.WriteLine("Please choose 0 or 1.");
    }
}
if (zeroOrOne == 0){
    output = (input*60)*60;
    timeStuff = time.seconds;
}else{
    output = input*60;
    timeStuff = time.minutes;
}
    return(output,timeStuff);
}






enum temepture {Celcius,Fahrenheit,Kelvin}
enum length {inches,feet,yard}
enum time {seconds,minutes,hours}