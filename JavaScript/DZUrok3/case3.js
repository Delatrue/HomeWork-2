"use strict";

const products = 
[
    {
        id: 3, price: 200,
    },
    {
        id: 4, price: 900,
    },
    {
        id: 1, price: 1000,
    },
];
for(let i = 0; i < products.length; i++)
{
    products[i].price = products[i].price - (products[i].price / 100 * 15);
}
products.forEach(products => console.log(products));