package com.codingdojo.justinbiddle.displaydate.controllers;

import java.text.SimpleDateFormat;
import java.util.Date;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class HomeController {
	@RequestMapping("/")
	public String index() {
		return "index.jsp";
	}
	@RequestMapping("/date")
	public String datepage(Model model) {
		Date date = new Date();
		String day = "EEEE";
		String number = "dd";
		String month = "MMMM";
		String year = "yyyy";
		SimpleDateFormat days = new SimpleDateFormat(day);
		SimpleDateFormat numbers = new SimpleDateFormat(number);
		SimpleDateFormat months = new SimpleDateFormat(month);
		SimpleDateFormat years = new SimpleDateFormat(year);
		String currDay = days.format(new Date());
		String currNumber = numbers.format(new Date());
		String currMonth = months.format(new Date());
		String currYear = years.format(new Date());
		model.addAttribute("currentDay", currDay);
		model.addAttribute("currentNumber", currNumber);
		model.addAttribute("currentMonth", currMonth);
		model.addAttribute("currentYear", currYear);
		return "dateday.jsp";
	}
	@RequestMapping("/time")
	public String timepage(Model model) {
		String time = "hh:mm a";
		SimpleDateFormat times = new SimpleDateFormat(time);
		String currTime = times.format(new Date());
		model.addAttribute("currentTime", currTime);
		return "datetime.jsp";
	}

}
