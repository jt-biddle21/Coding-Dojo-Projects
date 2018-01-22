package com.codingdojo.justinbiddle.counter.controllers;

import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class HomeController {
	@RequestMapping("/")
	public String home() {
		return "index.jsp";
	}
	@RequestMapping("/counter")
	public String counterPage(HttpSession session) {
		if (session.getAttribute("counter") == null) {
			session.setAttribute("counter", 0);
		}
		else {
			session.setAttribute("counter", (int)session.getAttribute("counter") + 1);
		}
		return "counter.jsp";
	}
	@RequestMapping("/reset")
	public String resetCounter(HttpSession session) {
		session.invalidate();
		return "redirect:/counter";
	}
	

}
