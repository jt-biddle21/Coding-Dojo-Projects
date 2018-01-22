    <%@ taglib prefix = "c" uri = "http://java.sun.com/jsp/jstl/core" %>
    <h2>You have visited this site <c:out value = "${counter}"/> times.</h2><hr>
    <a href="/">Go Home</a><br><br>
    <a href="/counter">Test another visit</a><br><br>
    <a href="/reset">Reset the counter</a>
    