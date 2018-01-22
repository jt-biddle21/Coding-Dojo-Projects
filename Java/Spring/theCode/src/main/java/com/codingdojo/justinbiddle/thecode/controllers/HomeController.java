package com.codingdojo.justinbiddle.thecode.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

@Controller
public class HomeController {
	@RequestMapping("/")
	public String index(@ModelAttribute("errors") String errors) {
		return "index.jsp";
	}
	@RequestMapping("/codeattempt")
	public String codepage(RedirectAttributes redirect, @RequestParam(name="attempt") String codeAttempt) {
		String code = "bushido";
		if (!codeAttempt.equals(code)) {
			redirect.addFlashAttribute("errors", "You must train harder!");
			return "redirect:/";
		}
		redirect.addFlashAttribute("good", "Welcome Ninja...");
		return "redirect:/code";
	}
}
