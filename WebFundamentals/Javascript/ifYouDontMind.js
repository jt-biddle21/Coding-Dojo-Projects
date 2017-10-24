var hour = 8;
var minute = 15;
var period = "AM";
var almost = "It's almost "
var after = "It's just after "

if(minute >= 30 && minute < 60 && period == "AM"){
    hour ++;
    if(hour = 13){
        hour = 1;
        console.log("It's " + hour + " in the evening!");
    }
    if(minute = 60){
        minute = 00;
        hour++;
        console.log("It's " + hour + " in the morning!");
    }
    console.log(almost + hour + " in the morning!");
}
else if(minute < 30 && period == "AM"){
    console.log(after + hour + " in the morning!");
}
else if(minute < 30 && period == "PM"){
    console.log(after + hour + " in the evening!");
}
else if(minute > 30 && minute < 60 && period == "PM"){
    hour++;
    if(hour = 13){
        hour = 1;
        console.log("It's " + hour + " in thev morning!");
    }
    if(minute = 60){
        minute = 00;
        hour++;
        console.log("It's " + hour + " in the evening!");
    }
    console.log(almost + hour + " in the evening!")
}
else{
    console.log("I have no idea what time it is!")
}