package com.codingdojo.justinbiddle.ninjagold.controllers;

import java.util.ArrayList;
import java.util.Random;

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
	@RequestMapping(path="/gold", method=RequestMethod.POST)
	public String mininggold(HttpSession session, @RequestParam(name="goldtype") String type) {
		if (session.getAttribute("gold") == null) {
			session.setAttribute("gold", 0);
		}
		if (type.equals("farm")) {
			Random rand = new Random();
			int low = 10;
			int high = 21;
			int result = rand.nextInt(high - low) + low;
			session.setAttribute("gold", (int)session.getAttribute("gold") + result);
			ArrayList<String> actions = new ArrayList<String>();
			String string = String.format("You entered a farm and earned %s gold", result);
			actions.add(string);
			session.setAttribute("action", actions);
		}
		if (type.equals("cave")) {
			Random rand = new Random();
			int low = 5;
			int high = 11;
			int result = rand.nextInt(high - low) + low;
			session.setAttribute("gold", (int)session.getAttribute("gold") + result);
			ArrayList<String> actions = new ArrayList<String>();
			String string = String.format("You entered a cave and earned %s gold", result);
			actions.add(string);
			session.setAttribute("action", actions);
		}
		if (type.equals("house")) {
			Random rand = new Random();
			int low = 2;
			int high = 6;
			int result = rand.nextInt(high - low) + low;
			session.setAttribute("gold", (int)session.getAttribute("gold") + result);
			ArrayList<String> actions = new ArrayList<String>();
			String string = String.format("You entered a house and earned %s gold", result);
			actions.add(string);
			session.setAttribute("action", actions);
		}
		if (type.equals("casino")) {
			Random rand = new Random();
			int low = -50;
			int high = 51;
			int result = rand.nextInt(high - low) + low;
			session.setAttribute("gold", (int)session.getAttribute("gold") + result);
			ArrayList<String> actions = new ArrayList<String>();
			String string = String.format("You entered a casino and earned %s gold", result);
			actions.add(string);
			System.out.println(actions);
			session.setAttribute("action", actions);
		}
		return "redirect:/";
	}
	@RequestMapping("/deposit")
	public String depositmoney(HttpSession session) {
		if (session.getAttribute("bank") == null) {
			session.setAttribute("bank", 0);
		}
		session.setAttribute("bank", (int)session.getAttribute("bank") + (int)session.getAttribute("gold"));
		session.setAttribute("gold", 0);
		return "redirect:/";
	}
	@RequestMapping("/withdraw")
	public String withdrawmoney(HttpSession session) {
		if ((int)session.getAttribute("bank") == 0) {
			session.setAttribute("nomoney", "You have no money in the bank. Please deposit money before withdrawing.");
		}
		session.setAttribute("gold", (int)session.getAttribute("bank") + (int)session.getAttribute("gold"));
		session.setAttribute("bank", 0);
		return "redirect:/";
	}
	@RequestMapping("/reset")
	public String restart(HttpSession session) {
		session.invalidate();
		return "redirect:/";
	}
}
