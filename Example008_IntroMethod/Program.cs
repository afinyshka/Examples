int a1 = 15;
int a2 = 21;
int a3 = 39;
int b1 = 12;
int b2 = 23;
int b3 = 89;
int c1 = 13;
int c2 = 23;
int c3 = 33;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);