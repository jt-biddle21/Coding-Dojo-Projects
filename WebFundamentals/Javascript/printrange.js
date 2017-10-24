function PrintRange(start, end, skip){
    for (var i = start; i <=end; i += skip){
        console.log(i);
    }
}
PrintRange(20, 200, 10);
return(PrintRange);