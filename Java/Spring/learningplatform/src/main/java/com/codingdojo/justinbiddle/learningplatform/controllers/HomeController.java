package com.codingdojo.justinbiddle.learningplatform.controllers;

import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class HomeController {
	@RequestMapping("/")
	public String index(HttpSession session) {
		return "index.jsp";
	}
	@RequestMapping("/goback")
	public String reset(HttpSession session) {
		session.invalidate();
		return "redirect:/";
	}
	@RequestMapping("/m/{chapter}/0483/{assignmentnumber}")
	public String assignment(HttpSession session, @PathVariable("chapter") Integer chapter, @PathVariable("assignmentnumber") Float assignment) {
		if (chapter == 26 && assignment == 2342) {
			session.setAttribute("content", "01000011 01101111 01101110 01110110 01100101 01110010 01110100 00100000 01110100 01100101 01111000 01110100 00100000 01110100 01101111 00100000 01100010 01101001 01101110 01100001 01110010 01111001");
			return "assignment.jsp";
		}
		else if(chapter == 38 && assignment == 0345F) {
			session.setAttribute("content", "The goal of this assignment is to create a forum");
			return "assignment.jsp";
		}
		return "redirect:/";
	}
	@RequestMapping("/m/{chapter}/0553/{lessonid}")
	public String lesson(HttpSession session, @PathVariable("chapter") Integer chapter, @PathVariable("lessonid") Float lesson) {
		if (chapter == 38 && lesson == 0733F) {
			session.setAttribute("content", "Here is how you set up your servers...");
			return "lesson.jsp";
		}
		else if(chapter == 38 && lesson == 0342F) {
			session.setAttribute("content", "Here is a quick lesson on how to do the punch card assignment...");
			return "lesson.jsp";
		}
		else if(chapter == 26 && lesson == 0348F) {
			session.setAttribute("content", "Here is an advanced intro to Fortran...");
			return "lesson.jsp";
		}
		return "redirect:/";
	}
}
