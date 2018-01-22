package com.codingdojo.justinbiddle.books.controllers;

import java.util.List;

import javax.validation.Valid;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import com.codingdojo.justinbiddle.books.models.Book;
import com.codingdojo.justinbiddle.books.services.BookService;
@Controller
public class Books {
    
    private final BookService bookService;
    public Books(BookService bookService){
        this.bookService = bookService;
    }
    //Can display all books here
    @RequestMapping("/books")
    public String books(Model model) {
        List<Book> books = bookService.allBooks();
        model.addAttribute("booksin", books);
        return "books.jsp";
    }
    @RequestMapping("/books/{index}")
    public String findbook(Model model, @PathVariable("index") int index) {
    		Book book = bookService.findBookByIndex(index);
        model.addAttribute("book", book);
        return "books.jsp";
    }
    @RequestMapping("/books/new")
    public String newBook(@ModelAttribute("book") Book book) {
        return "newBook.jsp";
    }

    @PostMapping("/books/new")
    	public String newBook(@Valid @ModelAttribute("book") Book book, BindingResult result) {
    		if (result.hasErrors()) {
    			return "newBook.jsp";
    		}else {
    			bookService.addBook(book);
    			return "redirect:/books";
    		}
    	}
}
