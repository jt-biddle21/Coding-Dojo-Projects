$(document).ready(function(){
    alert("JQ Working");
})
function quarterAmount(x) {
    if (x < 1) {
        return ("You don't have enough quarters to play!");
    }
    else {
        return ("With how many quarters you have, you can play " + x + " games!");
    }
}

