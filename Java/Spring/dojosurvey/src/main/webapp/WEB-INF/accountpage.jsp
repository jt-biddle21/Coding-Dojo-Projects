<%@ taglib prefix = "c" uri = "http://java.sun.com/jsp/jstl/core" %>
<a href="#">Submitted Info</a><br>
Name: <c:out value="${user}" /><br>
Location: <c:out value="${location}" /><br>
Language: <c:out value="${language}" /><br>
Comment: <c:out value="${comment}" /><br>
<a href="/goback">Go Back</a>