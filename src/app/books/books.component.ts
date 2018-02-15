import { Component, OnInit } from '@angular/core';
import { Book } from '../books/book'
import { BOOKS } from '../books/mock-books-service'
import { NgForOf } from '@angular/common/src/directives/ng_for_of';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {
 
   books = BOOKS;
  constructor() { }

  ngOnInit() {
  }

}
