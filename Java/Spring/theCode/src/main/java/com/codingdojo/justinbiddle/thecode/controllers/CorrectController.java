package com.codingdojo.justinbiddle.thecode.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class CorrectController {
	@RequestMapping("/code")
	public String correct(@ModelAttribute("goodjob") String good) {
		return "correctpage.jsp";
	}
}
