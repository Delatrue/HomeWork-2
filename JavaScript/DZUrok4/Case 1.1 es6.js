"use strict";

class Product2{
    constructor(name, price){
        this.name = name;
        this.price = price;
    }
    make25PercentDiscount(){
    this.price -= this.price / 100 * 25;
    };
}

const product2 = new Product2("Ноутбук", 50000);
product2.make25PercentDiscount();
console.log(product2);