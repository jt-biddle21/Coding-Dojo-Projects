var daysUntilMyBirthday = 60;

while (daysUntilMyBirthday <= 60 && daysUntilMyBirthday > 30){
    console.log(daysUntilMyBirthday + " days until my birthday... Such a long time :(");
    daysUntilMyBirthday --;
}
while (daysUntilMyBirthday <= 30 && daysUntilMyBirthday > 5){
    console.log(daysUntilMyBirthday + " days until my birthday!");
    daysUntilMyBirthday --;
}
while(daysUntilMyBirthday <= 5 && daysUntilMyBirthday > 0){
    console.log(daysUntilMyBirthday + " DAYS UNTIL MY BIRTHDAY");
    daysUntilMyBirthday --;
}
if (daysUntilMyBirthday === 0){
    console.log("IT'S MY BIRTHDAY!!!!!!!");
}