

public class StringManipulator {
    public String trimAndConcat(String str1, String str2){
        String newFirst = str1.trim();
        String newSecond = str2.trim();
        String finalWord = newFirst + newSecond;
        return finalWord;
    }
    public Integer getIndexOrNull(String str, char ch){
        int index = 0;
        for(int x = 0; x < str.length(); x++){
            if (str.charAt(x) == ch){
                index = x;
                return index;
            }
        }
        if (index == 0){
            return null;
        }
        return index;
    }
   
    public Integer getIndexOrNull(String str, String subStr){
        int index = 0;
        String temString = "";
        for(int x = 0; x < str.length(); x++){
            temString = "";
            if (x + subStr.length() < str.length() + 1) {                
                for (int y = x; y < subStr.length() + x; y++){
                    temString += str.charAt(y);
                }
                String tom = temString.trim();
                String cat = subStr.trim();
                index = x;
                if(tom == cat){
                    index = x;
                    break;
                }
            }
        }
        if (index == 0) {
            return null;
        }
        return index;
    }

    public String concatSubstring(String str1, int index1, int index2, String str2){
        String temString = "";
        String finalString = "";
        for (int x = index1; x < str1.length(); x++){
            if(x < index2){
                temString += str1.charAt(x);
            }
        }
        finalString = temString + str2;
        return finalString;
    }
}