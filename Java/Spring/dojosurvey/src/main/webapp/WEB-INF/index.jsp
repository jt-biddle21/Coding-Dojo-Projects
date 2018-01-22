<%@ taglib prefix = "c" uri = "http://java.sun.com/jsp/jstl/core" %>
<h2>Please log in:</h2>
<form method="POST" action="/login">
    <label>Your Name: <input type="text" name="name"></label><br>
    Dojo Location: <select name="location">
    <option value="Seattle">Seattle</option>
    <option value="San Jose">San Jose</option>
    <option value="D.C.">D.C.</option></select><br>
    Favorite Language: <select name="language">
    <option value="Python">Pyhton</option>
    <option value="Java">Java</option>
    <option value="C#">C#</option></select><br>
    <label>Comment (optional)</label><br>
    <textarea name="comment" rows=10 cols=50></textarea><br>
    <button>Submit</button>
</form>
<c:out value="${error}" />