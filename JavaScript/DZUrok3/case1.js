// Спасибо за обратную свзяь. С данного дз буду использовать строгий режим
"use strict";

for(let i = 0; i <= 10; i++ )
{
    if(i == 0)
    {
        console.log("0 - это ноль");
    }
    else if(i % 2 == 0)
    {
        console.log(i + " - четное число");
    }
    else
    {
        console.log(i + " - нечетное число");
    }
}