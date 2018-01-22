package com.codingdojo.justinbiddle.dojosurvey.controllers;

import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class DashboardController {
	@RequestMapping("/dashboard")
	public String dash(HttpSession session) {
		return "accountpage.jsp";
	}
	@RequestMapping("/goback")
	public String reset(HttpSession session) {
		session.invalidate();
		return "redirect:/";
	}
}
