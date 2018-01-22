package com.codingdojo.justinbiddle.hellohuman.controllers;

import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class GreetController {
	@RequestMapping("/")
	public String index(@RequestParam(value="firstname", required=false) String x, @RequestParam(value="lastname", required=false) String y, HttpSession session) {
		if (session.getAttribute("firstName") == null && session.getAttribute("lastName") == null) {
			session.setAttribute("firstName", "Human");
			session.setAttribute("lastName", "Humanson");
		}
		else {
			session.setAttribute("firstName", x);
			session.setAttribute("lastName", y);
		}
		return "index.jsp";
	}
	@RequestMapping("/goback")
	public String reset(HttpSession session) {
		session.invalidate();
		return "redirect:/";
	}
}
