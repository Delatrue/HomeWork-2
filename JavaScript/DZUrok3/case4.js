"use strict";

const products = 
[
    {
        id: 3,
        price: 127,
        photos: 
        [
            "1.jpg",
            "2.jpg",
        ]
    },
    {
        id: 5,
        price: 499,
        photos: []
    },
    {
        id: 10,
        price: 26,
        photos: 
        [
            "3.jpg",
        ]
    },
    {
        id: 8,
        price: 78,
    },
];

// вывод товаров с фото
let withPhoto = products.filter(value => "photos" in value && value.photos.length > 0);
console.log(withPhoto);

// сортировка товаров по цене по возрастанию
products.sort(function(valueA, valueB)
{
    if(valueA.price > valueB.price)
    {
        return 1;
    }
    if(valueA.price < valueB.price)
    {
        return -1;
    }
    else
    {
        return 0;
    }

});

for(let i = 0; i < products.length; i++)
    {
        console.log(products[i].price);
    }
