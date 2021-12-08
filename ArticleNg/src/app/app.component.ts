import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { ArticleService } from '../app/article.service';
import { Article } from '../app/article.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(private articleService: ArticleService) {}

  title = 'ArticleNg title';

  articles: any;
  
  //getArticles(): void {
  //  this.articles = this.articleService.getArticles();
  //}

  ngOnInit() {
    this.articleService.getArticles().subscribe(
      (response) => { this.articles = response; },
      (error) => { console.log(error); }
    );
  }
}
