<%@ taglib prefix = "c" uri = "http://java.sun.com/jsp/jstl/core" %>
<a href="/reset">Restart Game</a><br><br>
<h3>Your Gold: <c:out value="${gold}" /></h3>
<h4>Farm (earns 10-20 gold)</h4>
<form action="/gold" method="POST">
	<input type="hidden" name="goldtype" value="farm">
	<input type="submit" value="Find Gold!">
</form><hr>
<h4>Cave (earns 5-10 gold)</h4>
<form action="/gold" method="POST">
	<input type="hidden" name="goldtype" value="cave">
	<input type="submit" value="Find Gold!">
</form><hr>
<h4>House (earns 2-5 gold)</h4>
<form action="/gold" method="POST">
	<input type="hidden" name="goldtype" value="house">
	<input type="submit" value="Find Gold!">
</form><hr>
<h4>Casino (earns/takes 0-50 gold)</h4>
<form action="/gold" method="POST">
	<input type="hidden" name="goldtype" value="casino">
	<input type="submit" value="Find Gold!">
</form>
<c:if test="${gold > 0}" >
<a href="/deposit">Deposit all money into the bank</a><br><br>
</c:if>
<c:if test="${bank > 0}" >
<a href="/withdraw">Withdraw all money from the bank</a>
<h4><c:out value="${nomoney}" /></h4></c:if>

<!-- Not sure how to loop and display all of the activites. But when i sysout them, they are there. -->
<c:forEach items="${actions}" var="item">
	<p><c:out value="${item}"/></p>
</c:forEach>