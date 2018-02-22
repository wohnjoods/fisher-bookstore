import { Component, OnInit, Input } from '@angular/core';
import { IBook } from '../books/book';
import { FormsModule } from '@angular/forms';
import { BooksService } from '../books/books.service'

@Component({
  selector: 'app-book-detail',
  templateUrl: './book-detail.component.html',
  styleUrls: ['./book-detail.component.css']
})
export class BookDetailComponent implements OnInit {

  @Input() book: IBook;
  constructor() { }

  ngOnInit() {
  }

}
