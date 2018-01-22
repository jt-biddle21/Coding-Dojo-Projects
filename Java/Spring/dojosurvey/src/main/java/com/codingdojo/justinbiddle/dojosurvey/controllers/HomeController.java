package com.codingdojo.justinbiddle.dojosurvey.controllers;

import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class HomeController {
	@RequestMapping("/")
	public String index() {
		return "index.jsp";
	}
	@RequestMapping(path="/login", method=RequestMethod.POST)
	public String logging(@RequestParam(value="name") String user, @RequestParam(value="location") String location, @RequestParam(value="language") String lang, @RequestParam(value="comment") String comment, HttpSession session) {
		session.setAttribute("user", user);
		session.setAttribute("location", location);
		session.setAttribute("language", lang);
		session.setAttribute("comment", comment);
		String w = (String)session.getAttribute("user");
		String x = (String)session.getAttribute("location");
		String y = (String)session.getAttribute("language");
		if (y.equals("Java")) {
			return "redirect:/javachoice";
		}
		String z = (String)session.getAttribute("comment");
		System.out.println(w + " " + x + " " +  y + " " + z);
		if (session.getAttribute("user").equals("")|| session.getAttribute("location").equals("") || session.getAttribute("language").equals("")) {
			session.setAttribute("error", "You need to actually fill in the survey");
			return "redirect:/";
		}
		return "redirect:/dashboard";
	}
	@RequestMapping("/javachoice")
	public String java() {
		return "javapage.jsp";
	}
}
