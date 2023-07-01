int distance = 1000;    // расстояние между друзьями (в метрах)
int dogSpeed = 5;       // скорость собаки (в метрах в секунду)
int firstFriendSpeed = 1;    // скорость первого друга (в метрах в секунду)
int secondFriendSpeed = 2;   // скорость второго друга (в метрах в секунду)

// Расстояние, которое пройдет собака за один круг, составляет сумму расстояний между друзьями и скорости собаки.
double dogDistancePerLap = (double)(distance * 2) + dogSpeed;

// Расстояние, которое пройдет первый друг за одну секунду, будет равно его скорости.
double firstFriendDistancePerSec = firstFriendSpeed;

// Расстояние, которое пройдет второй друг за одну секунду, будет равно его скорости тоже.
double secondFriendDistancePerSec = secondFriendSpeed;

// Расстояние между друзьями будет уменьшаться на расстояние, которое они пройдут за одну секунду.
while(distance > 10)
{
    // Сначала перемещается первый друг, затем -- собака, затем -- второй друг.
    distance -= (int)firstFriendDistancePerSec;
    dogDistancePerLap -= dogSpeed;
    distance -= (int)secondFriendDistancePerSec;
    dogDistancePerLap -= dogSpeed;
}

// Расчет количества кругов, пройденных собакой
int lapCount = (int)(dogDistancePerLap / ((double)distance * 2));

Console.WriteLine($"Собака сделала {lapCount} круг(а/ов) до того, как друзья встретились");