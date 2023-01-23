int[] moto = {};
double carSum = 0;
double motoSum = 0;
int transportCount;

Console.WriteLine("Введите количество Машин и Мотоциклов: ");
transportCount = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= transportCount; i++)
{
    Console.WriteLine("Введите стоимость " + i + "й" + " машины: ");
    car[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i <= transportCount; i++)
{
    Console.WriteLine("Введите стоимость " + i + "" + " мотоцикла: ");
    moto[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i < transportCount; i++)
{
    carSum = carSum + car[i];
    motoSum = motoSum + moto[i];
}
carSum = carSum / transportCount;
motoSum = motoSum / transportCount;
if ((carSum / 3) > motoSum)
{
    Console.WriteLine("Верно!");
}
else
{
    Console.WriteLine("Не верно!");

}
