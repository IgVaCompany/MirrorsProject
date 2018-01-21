//---------------------------------------------------------------------------
/*

  Mirrors project. module. 
  GornostaevIV

*/

//---------------------------------------------------------------------------

// Distance calculation between the points (x1;y1) and (x2;y2).
double distanse(double x1, double y1, double x2, double y2)
{
    double answer; 
    answer = sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
    return answer;
}

// Cross point of two straight lines.
// First line: y = a1*x + b1. Second line: y = a2*x + b2.
double crosspointX(double a1, double b1, double a2, double b2)
{
    double answer;
    if ((a1-a2) == 0)
        {
            return 0;
        }
        else
        {
            answer = (b2-b1)/(a1-a2);
            return answer;
        }
}

// Cross point of two straight lines.
// First line: y = a1*x + b1. Second line: y = a2*x + b2.
double crosspointY(double a1, double b1, double a2, double b2)
{
    double answer;
    if ((a1-a2) == 0)
        {
            return 0;
        }
        else
        {
            answer = a1*(b2-b1)/(a1-a2)+b1;
            return answer;
        }
}

// "a" coefficient calculation.
// y = a*x + b.
double acalc(double x1, double y1, double x2, double y2)
{
    double answer;
    if ((x2-x1) == 0)
        {
            return 0; // ! its necessary to edit it after
        }
        else
        {
            answer = (y2-y1)/(x2-x1);
            return answer;
        }
}

// "b" coefficient calculation.
// y = a*x + b.
double bcalc(double x1, double y1, double x2, double y2)
{
    double answer;
    if ((x2-x1) == 0)
        {
            return 0; // ! its necessary to edit it after
        }
        else
        {
            answer = (y1*x2 - x1*y2)/(x2-x1);
            return answer;
        }
}


// "b" coefficient calculation.
// y = a*x + b.
double bcalc2(double x, double y, double a)
{
    double answer;
    answer = y - a*x;
    return answer;

}

// Check orthogonality.
bool orthogonality(double a1, double a2)
{
    bool answer = false;
    if ((a1*a2 < -1.01)&&(a1*a2 > -0.99)) answer = true;
    return answer;
}

// Check parallelism.
bool parallelism(double a1, double a2)
{
    bool answer = false;
    if ((a1 > (a2 - a2*0.01))&&(a1 < (a2 + a2*0.01))) answer = true;
    return answer;
}

// Is there crosspoint of the piece (x0;y0)-(x1;y1) and line (x2;y2)-(x3;y3)?
bool existencecrossing (double x0, double y0, double x1, double y1, double x2, double y2, double x3, double y3)
{
    bool answer = false;
    double a01 = 0; // a-coef : (x0;y0)-(x1;y1)
    double b01 = 0; // b-coef : (x0;y0)-(x1;y1)
    double a23 = 0; // a-coef : (x2;y2)-(x3;y3)
    double b23 = 0; // b-coef : (x2;y2)-(x3;y3)

    a01 = acalc(x0, y0, x1, y1);
    b01 = bcalc(x0, y0, x1, y1);
    if ((a01 == 0)&&(b01 == 0))
        {
        a01 = acalc(x0+1, y0, x1, y1);  // ? check it after
        b01 = bcalc(x0+1, y0, x1, y1);  // ? check it after
        }
    a23 = acalc(x2, y2, x3, y3);
    b23 = bcalc(x2, y2, x3, y3);
    if ((a23 == 0)&&(b23 == 0))
        {
        a23 = acalc(x2+1, y2, x3, y3);  // ? check it after
        b23 = bcalc(x2+1, y2, x3, y3);  // ? check it after
        }

    // Crosspoint calculation.
    double pointX = 0; 
    double pointY = 0; 

    pointX = crosspointX(a01, b01, a23, b23);
    pointY = crosspointY(a01, b01, a23, b23);

   // +-1 - computational error.
    if (((pointX >= x0-1)&&(pointX <= x1+1))||((pointX <= x0+1)&&(pointX >= x1-1)))
       {
       if  (((pointY >= y0)&&(pointY <= y1))||((pointY <= y0)&&(pointY >= y1)))
           {
           answer = true;
           }
       }
       return answer;
}

/*
// The crosspoint calculation of the piece (x0;y0)-(x1;y1) and piece (x2;y2)-(x3;y3).
bool existencecrossing2 (double x0, double y0, double x1, double y1, double x2, double y2, double x3, double y3)
{
    bool answer = false;
    double a01 = 0; // a-coef : (x0;y0)-(x1;y1)
    double b01 = 0; // b-coef : (x0;y0)-(x1;y1)
    double a23 = 0; // a-coef : (x2;y2)-(x3;y3)
    double b23 = 0; // b-coef : (x2;y2)-(x3;y3)

    a01 = valueconstA(x0, y0, x1, y1);
    b01 = valueconstB(x0, y0, x1, y1);
    if ((a01 == 0)&&(b01 == 0))
        {
        a01 = valueconstA(x0+1, y0, x1, y1);
        b01 = valueconstB(x0+1, y0, x1, y1);
        }
    a23 = valueconstA(x2, y2, x3, y3);
    b23 = valueconstB(x2, y2, x3, y3);
    if ((a23 == 0)&&(b23 == 0))
        {
        a23 = valueconstA(x2+1, y2, x3, y3);
        b23 = valueconstB(x2+1, y2, x3, y3);
        }

    // Crosspoint calculation.
    double pointX = 0; 
    double pointY = 0; 

    pointX = crossingpointX(a01, b01, a23, b23);
    pointY = crossingpointY(a01, b01, a23, b23);

   // +-1 - computational error.
    if ((((pointX >= x0-1)&&(pointX <= x1+1))||((pointX <= x0+1)&&(pointX >= x1-1)))&&
       (((pointX >= x2-1)&&(pointX <= x3+1))||((pointX <= x2+1)&&(pointX >= x3-1))))
       {
       if  ((((pointY >= y0)&&(pointY <= y1))||((pointY <= y0)&&(pointY >= y1)))&&
           (((pointY >= y2)&&(pointY <= y3))||((pointY <= y2)&&(pointY >= y3))))
           {
           answer = true;
           }
       }
       return answer;
}
  */
//---------------------------------------------------------------------------

// Algoritm:
// 0. Preparation of calculation data.
// 1. Find all mirrors parallel to ray. Eliminate it.
// 2. Find cross points of the mirrors and ray. See it.
// 3. Let (x0;у0) - ray beggining, (х1;у1) - ray end.
//     if (x1-x0) >0 then ray is right directed. Eliminate the points that have x<x0.
//     if (x1-x0) <0 then ray is left  directed. Eliminate the points that have x>x0.
//     if (x1-x0) =0 then ray is vertical. Save points that have х=х0 only and check y values.
//         if (y1-y0) > 0 then the ray is high directed. Eliminate the points that have y<y0. 
//         if (y1-y0) < 0 then the ray is low  directed. Eliminate the points that have y>y0.
//         if (y1-y0) = 0 then ray is point. It is error.
// 4. Calculate distance (х0;у0) to the points. Choose the closest point (x2;y2).
// 5. Calculate angle between the ray and mirror.
// 6. Calculate new ray. Goto Part 1.
// 7. Save and show data.

void CYCLING(double x1, double y1, double x2, double y2)
{

// GLOBAL
int arraymirrors [100][2];        // Mirrors array lying through (x0;y0)-(x1;y1) points.
int firstray     [2][2];          // 
double outrays   [100][2];        // Result ray path. Save it in file.
double outinf    [3] = {0};       // Output information array.
int i = 0;                        // Pointer.
int i_ray = 1;                    // Global pointer.

// Global arrays initialization
for (i=0 ; i < 100 ; i++)
    {
    outrays [i][0] = 0;
    outrays [i][1] = 0;
    }
i = 0;
for (i=0 ; i < 100 ; i++)
    {
    arraymirrors [i][0] = 0;
    arraymirrors [i][1] = 0;
    }
i = 0;

// Save datd to arraymirrors[100][2]_
// TEST

/*  
    //Vertical mirrors.
    arraymirrors[0][0]   = 50;
    arraymirrors[0][1]   = 50;
    arraymirrors[1][0]   = 50;
    arraymirrors[1][1]   = 250;

    arraymirrors[2][0]   = 350;
    arraymirrors[2][1]   = 50;
    arraymirrors[3][0]   = 350;
    arraymirrors[3][1]   = 250;

    arraymirrors[4][0]   = 450;
    arraymirrors[4][1]   = 50;
    arraymirrors[5][0]   = 450;
    arraymirrors[5][1]   = 250;

    firstray[0][0] = 100;
    firstray[0][1] = 150;
    firstray[1][0] = 250;
    firstray[1][1] = 150;   
*/

/*
    // Parallel mirrors.
    arraymirrors[0][0]   = 150;
    arraymirrors[0][1]   = 350;
    arraymirrors[1][0]   = 2000;
    arraymirrors[1][1]   = 350;

    arraymirrors[2][0]   = 150;
    arraymirrors[2][1]   = 150;
    arraymirrors[3][0]   = 2000;
    arraymirrors[3][1]   = 150;

    firstray[0][0] = 100;
    firstray[0][1] = 200;
    firstray[1][0] = 200;
    firstray[1][1] = 300; 
*/

// Various mirrors.
    arraymirrors[0][0]   = 0;
    arraymirrors[0][1]   = 1;
    arraymirrors[1][0]   = 200;
    arraymirrors[1][1]   = 1;

    arraymirrors[2][0]   = 200;
    arraymirrors[2][1]   = 1;
    arraymirrors[3][0]   = 200;
    arraymirrors[3][1]   = 100;

    arraymirrors[4][0]   = 200;
    arraymirrors[4][1]   = 100;
    arraymirrors[5][0]   = 0;
    arraymirrors[5][1]   = 100;

    arraymirrors[6][0]   = 0;
    arraymirrors[6][1]   = 100;
    arraymirrors[7][0]   = 0;
    arraymirrors[7][1]   = 1;

    firstray[0][0] = 100;
    firstray[0][1] = 2;
    firstray[1][0] = 200;
    firstray[1][1] = 50;


// ______________________
// =-=-=-= PART 0 =-=-=-=
// ______________________

int    raysref = 0;  // Number of reflections
double pasdist = 0 ; // The distance passed by the ray.
int    raysnum = 0;  // Number of rays.

double arrayline  [100][2];    	// All mirrors [a][b].
double arraypoint [100][2];    	// Cross points of the ray and mirrors.
int pointX = 0;  		// The Х-coordinate of the closest cross point.
int pointY = 0;  		// The Y-coordinate of the closest cross point.
int number_mirror = 0;  	// Nubmer of mirror reflected the ray.

const double pi = 3.1415926535897932384626433832795;

for (i=0 ; i < 100 ; i++)
    {
    arrayline[i][0] = 0;
    arrayline[i][1] = 0;
    }
i = 0;
for (i=0 ; i < 100 ; i++)
    {
    arraypoint[i][0] = 0;
    arraypoint[i][1] = 0;
    }
i = 0;

struct ray                     
    {
    double x0;
    double x1;
    double y0;
    double y1;
    double aray;
    double bray;
    };
ray myray;  // last ray.

myray.x0    = firstray[0][0];
myray.y0    = firstray[0][1];
myray.x1    = firstray[1][0];
myray.y1    = firstray[1][1];
myray.aray  = acalc(myray.x0, myray.y0, myray.x1, myray.y1);
myray.bray  = bcalc(myray.x0, myray.y0, myray.x1, myray.y1);

outrays[0][0] = firstray [0][0];
outrays[0][1] = firstray [0][1];

// Calculate all mirrors coefficients.
for (i=0 ; i<100 ; i+=2)
    {
    arrayline[i][0] = valueconstA(arraymirrors[i][0], arraymirrors[i][1], arraymirrors[i+1][0], arraymirrors[i+1][1]);
    arrayline[i][1] = valueconstB(arraymirrors[i][0], arraymirrors[i][1], arraymirrors[i+1][0], arraymirrors[i+1][1]);
    // if the mirror is vertical.
    if ((arrayline[i][0] == 0)&&(arrayline[i][1] == 0))
        {
        arrayline[i][0] = valueconstA(arraymirrors[i][0]+1, arraymirrors[i][1], arraymirrors[i+1][0], arraymirrors[i+1][1]);
        arrayline[i][1] = valueconstB(arraymirrors[i][0]+1, arraymirrors[i][1], arraymirrors[i+1][0], arraymirrors[i+1][1]);
        }
    }
i=0;

// -_-_-_-_-_-_-_-_-_-_-_- metka: -_-_-_-_-_-_-_-_-_-_-_-_-_-_-_
metka:

number_mirror = 0;

// ______________________
// =-=-=-= PART 1 =-=-=-=
// ______________________

double arrayline_copy[100][2];
for (i=0 ; i < 100 ; i++)
    {
    arrayline_copy[i][0] = arrayline[i][0];
    arrayline_copy[i][1] = arrayline[i][1];
    }
i = 0;

// Eliminate parallel mirrors.
for (i=0 ; i < 100 ; i++)
    if (parallelism(myray.aray, arrayline_copy[i][0]))
        {
        arrayline_copy[i][0] = 0;
        arrayline_copy[i][1] = 0;
        }

// ______________________
// =-=-=-= PART 2 =-=-=-=
// ______________________

// ? Error: ortogonal mirrors are parallel? 
for (i=0 ; i < 100 ; i += 2)
    {
    if ((arrayline_copy[i][0] != 0)||(arrayline_copy[i][1] != 0))
        {
        arraypoint[i][0]   = crossingpointX( myray.aray, myray.bray, arrayline_copy[i][0], arrayline_copy[i][1] );
        arraypoint[i][1]   = crossingpointY( myray.aray, myray.bray, arrayline_copy[i][0], arrayline_copy[i][1] );
        }
    }
i = 0;

// ______________________
// =-=-=-= PART 3 =-=-=-=
// ______________________

if ((myray.x1-myray.x0) >0)
    for (i=0 ; i < 100 ; i+=2)
        {
        if (arraypoint[i][0] < myray.x0)
            {
            arraypoint[i][0] = 0;
            arraypoint[i][1] = 0;
            }
        }

if ((myray.x1-myray.x0) <0)
    for (i=0 ; i < 100 ; i+=2)
        {
        if (arraypoint[i][0] > myray.x0)
            {
            arraypoint[i][0] = 0;
            arraypoint[i][1] = 0;
            }
        }

if ((myray.x1-myray.x0) == 0)
    {
    for (i=0 ; i < 100 ; i+=2)
        {
        if (arraypoint[i][0] != myray.x0)
            {
            arraypoint[i][0] = 0;
            arraypoint[i][1] = 0;
            }
        }

        if ((myray.y1-myray.y0) > 0)
            for (i=0 ; i < 100 ; i+=2)
                {
                if (arraypoint[i][1] < myray.y0)
                    {
                    arraypoint[i][0] = 0;
                    arraypoint[i][1] = 0;
                    }
                }

        if ((myray.y1-myray.y0) < 0)
            for (i=0 ; i < 100 ; i+=2)
                {
                if (arraypoint[i][1] > myray.y0)
                    {
                    arraypoint[i][0] = 0;
                    arraypoint[i][1] = 0;
                    }
                }

        if ((myray.y1-myray.y0) == 0) ; //ShowMessage ("HERETIC DATA!");
    }
i = 0;

// ______________________
// =-=-=-= PART 4 =-=-=-=
// ______________________

double dist_1 = 0; // Min distance.                 
double dist_2 = 0; // Distance to second point.


// Crossing check of the ray and mirrors.
// +-1 - computational error.
for (i=0 ; i < 100 ; i+=2)
    {
    if ((arraypoint[i][0] != 0)||(arraypoint[i][1] != 0))
        {
        if  (!((((arraymirrors[i][0]-1 <= arraypoint[i][0])&&(arraymirrors[i+1][0]+1 >= arraypoint[i][0]))||               
            ((arraymirrors[i][0]+1 >= arraypoint[i][0])&&(arraymirrors[i+1][0]-1 <= arraypoint[i][0])))&&
            (((arraymirrors[i][1]-1 <= arraypoint[i][1])&&(arraymirrors[i+1][1]+1 >= arraypoint[i][1]))||
            ((arraymirrors[i][1]+1 >= arraypoint[i][1])&&(arraymirrors[i+1][1]-1 <= arraypoint[i][1])))))
            {
            arraypoint[i][0] = 0;
            arraypoint[i][1] = 0;
            }
        }
    }
i = 0;


// First point is closest in the beggining.
for (i=0 ; i < 100 ; i+=2)
    {
    if ((arraypoint[i][0] != 0)||(arraypoint[i][1] != 0))
        {
        pointX = arraypoint[i][0];
        // Eliminate computational error (1 pixel) at every calculation. 
        if (((arraypoint[i][0] - pointX)*(arraypoint[i][0] - pointX)) >= 0.25) pointX = pointX+1;
        pointY = arraypoint[i][1];
        // Eliminate computational error (1 pixel) at every calculation. 
        if (((arraypoint[i][1] - pointY)*(arraypoint[i][1] - pointY)) >= 0.25) pointY = pointY+1;
        dist_1 = distanse( pointX , pointY , myray.x0 , myray.y0 );
        number_mirror = i; 
        break;
        }
    }
i = 0;

// Find closest point.
for (i=0 ; i < 100 ; i+=2)
    {
    if ((arraypoint[i][0] != 0)||(arraypoint[i][1] != 0))
        {
        dist_2 = distanse(arraypoint[i][0] , arraypoint[i][1] , myray.x0 , myray.y0);
        if (((dist_1 > dist_2)&&(dist_2 > 1))||((dist_1 < 1)&&(dist_2 > 1)))
            {
            dist_1 = dist_2;
            pointX = arraypoint[i][0];
            // Eliminate computational error (1 pixel) at every calculation. 
            if (((arraypoint[i][0] - pointX)*(arraypoint[i][0] - pointX)) >= 0.25) pointX = pointX+1;
            pointY = arraypoint[i][1];
            if (((arraypoint[i][1] - pointY)*(arraypoint[i][1] - pointY)) >= 0.25) pointY = pointY+1;
            dist_1 = distanse( pointX , pointY , myray.x0 , myray.y0 );
            number_mirror = i; 
            }
        }
    }
i = 0;

// ______________________
// =-=-=-= PART 5 =-=-=-=
// ______________________

double alfa   = 0;  // Calculate the angle.
double betta  = 0;  // Ray angle.
double gamma  = 0;  // Angle of the mirror.
double a_alfa = 0;  // a-coefficient of the reflected line.

// находим betta и gamma_
if ((myray.aray == 0)&&(myray.x0 - myray.x1 == 0))
    betta = pi/2;
    else betta = atan (myray.aray);
if ((arrayline_copy[number_mirror][0] == 0)&&(arraymirrors[number_mirror][0] - arraymirrors[number_mirror+1][0]))
    gamma = pi/2;
    else gamma = atan (arrayline_copy[number_mirror][0]);
alfa = 2*gamma - betta;

// alfa valculation of new ray.
if ((alfa == pi/2)||(alfa == 3*pi/2))
    a_alfa = 0;
    else
    a_alfa = tan (alfa);

// ______________________
// =-=-=-= PART 6 =-=-=-=
// ______________________

double final_a = 0; // a-coefficient of the reflected ray.
double final_b = 0; // b-coefficient of the reflected ray.
final_a = a_alfa;
final_b = valueconstB2 (pointX, pointY, final_a);

double x_1 = 0;
double y_1 = 0;
double x_2 = 0;
double y_2 = 0;

// if the line is not vertical, then calculate points soluting quadratic equation.
if ((alfa != pi/2)||(alfa != 3*pi/2))
    {
    double a = 0;
    double b = 0;
    double c = 0;
    double D = 0; // Discriminant.
   
// Calculate second ray point. First point - (pointX, pointY)
// x_1 and y_1 - coordinates of the first possible point. x_2 and y_2 - second.
//   dist_1^2 = (x_1 - pointX)^2 + (y_1 - pointY)^2.
//   y_1 = a_alfa*x_1 + b.
//     y = ax^2 + bx + c

    a = 1 + final_a*final_a;
    b = 2*final_a*final_b - 2*pointX - 2*pointY*final_a;
    c = final_b*final_b + pointY*pointY + pointX*pointX - 2*pointY*final_b - dist_1*dist_1;
    D = b*b - 4*a*c;

    x_1 = (-b + sqrt(D))/(2*a);        // For first  possible point.
    y_1 = final_a*x_1 + final_b;

    x_2 = (-b - sqrt(D))/(2*a);        // For second possible point.
    y_2 = final_a*x_2 + final_b;
    }
    else
    {
    x_1 = pointX;
    y_1 = pointY + dist_1;

    x_2 = pointX;
    y_2 = pointY - dist_1;
    }

// Save new reflection point.
outrays[i_ray][0] = pointX;
outrays[i_ray][1] = pointY;
i_ray++;

// Increase the passed distance.
pasdist += distanse(myray.x0, myray.y0, pointX, pointY);

if (!existencecrossing(myray.x0, myray.y0, x_1, y_1, arraymirrors[number_mirror][0], arraymirrors[number_mirror][1], arraymirrors[number_mirror+1][0], arraymirrors[number_mirror+1][1]))
    {
    // New ray - new parameters.
    myray.x0    = pointX;
    myray.y0    = pointY;
    myray.x1    = x_1;
    myray.y1    = y_1;
    myray.aray  = valueconstA(myray.x0, myray.y0, myray.x1, myray.y1);
    myray.bray  = valueconstB(myray.x0, myray.y0, myray.x1, myray.y1);
    }
    else
    {
    // New ray - new parameters.
    myray.x0    = pointX;
    myray.y0    = pointY;
    myray.x1    = x_2;
    myray.y1    = y_2;
    myray.aray  = valueconstA(myray.x0, myray.y0, myray.x1, myray.y1);
    myray.bray  = valueconstB(myray.x0, myray.y0, myray.x1, myray.y1);
    }

// Clear old information.
for (i=0 ; i < 100 ; i++)
    {
    arraypoint[i][0] = 0;
    arraypoint[i][1] = 0;
    }
i = 0;

pointX = 0;
pointY = 0;

// Refresh counters .
raysref++;
raysnum++;

ProgressBar1->Position++;


// go to begining
if ((raysnum < 8)||((myray.y0 == myray.y1)&&(myray.x0 == myray.x1))) goto metka;

outinf [0] = raysref;
outinf [1] = pasdist;
outinf [2] = pasdist;

// TEST
/*
ofstream outfile;     // Save data to file.
outfile   .open("out_inf.txt");
outfile  << "Число отражений: " << raysref << endl
         << "Число построенных лучей: " << raysnum << endl
         << "Пройденное главным лучом расстояние: " << pasdist << endl
         << "( " << outrays[0][0]  << " ; " << outrays[0][1]  << " )" << endl
         << "( " << outrays[1][0]  << " ; " << outrays[1][1]  << " )" << endl
         << "( " << outrays[2][0]  << " ; " << outrays[2][1]  << " )" << endl
         << "( " << outrays[3][0]  << " ; " << outrays[3][1]  << " )" << endl
         << "( " << outrays[4][0]  << " ; " << outrays[4][1]  << " )" << endl
         << "( " << outrays[5][0]  << " ; " << outrays[5][1]  << " )" << endl
         << "( " << outrays[6][0]  << " ; " << outrays[6][1]  << " )" << endl
         << "( " << outrays[7][0]  << " ; " << outrays[7][1]  << " )" << endl
         << "( " << outrays[8][0]  << " ; " << outrays[8][1]  << " )" << endl
         << "( " << outrays[9][0]  << " ; " << outrays[9][1]  << " )" << endl;

outfile.close();
*/
}