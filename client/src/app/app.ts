import { HttpBackend, HttpClient } from '@angular/common/http';
import { Component, inject, OnInit, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Subscriber } from 'rxjs';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {

  private http = inject(HttpClient);
  protected readonly title = signal("Dating App");

  // Otra forma de llamarlo desde el html
  // quedaria de la siguiente forma:
  // <h1>{{title2}}</h1>
  // protected title2 = "Hola";

  // Constructor tradicional que se puede susituir
  // con el de inject
  // constructor(private http2: HttpClient) { }

  ngOnInit(): void {
    this.http.get("https://localhost:5001/api/members").subscribe({
      next: response => console.log(response),
      error: error => console.log(error),
      complete: () =>console.log('Completed the http reqest')

    });
  }
}

