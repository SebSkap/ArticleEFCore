import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ArticleService {

  constructor(private http: HttpClient) { }

  articleUrl = 'https://localhost:44387/api/Articles';

  getArticles() {
    return this.http.get(this.articleUrl);
  }
}

export interface Article {
  id: number;
  code: string;
  name: string;
}