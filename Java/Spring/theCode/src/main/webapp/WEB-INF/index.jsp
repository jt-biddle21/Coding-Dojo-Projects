<%@ taglib prefix = "c" uri = "http://java.sun.com/jsp/jstl/core" %>
<p><c:out value="${errors}" /></p>
<h3>What is the code?</h3>
<form action="/codeattempt" method="post">
<label><input type="text" name="attempt"></label>
<button>Try Code!</button>
</form>