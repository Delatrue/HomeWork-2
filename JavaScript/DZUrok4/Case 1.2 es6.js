"use strict";

class Post2{
    constructor(author, text, date){
        this.author = author;
        this.text = text;
        this.date = date;        
    }
    edit(text){
        this.text = text;
    }
}

class AttachedPostEs6 extends Post2{
    constructor(author, text, date){
        super(author, text, date);
        this.highlightedEs6 = false;
    }

    makeTextHighlitedEs6(){
        this.highlightedEs6 = true;
    }
}

const attachedPost2 = new AttachedPostEs6("Телеграмм", "война", new Date());
console.log(attachedPost2);
attachedPost2.makeTextHighlitedEs6();
attachedPost2.edit("мир");
console.log(attachedPost2);