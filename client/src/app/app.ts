import { HttpBackend, HttpClient } from '@angular/common/http';
import { Component, inject, OnInit, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { lastValueFrom, Subscriber } from 'rxjs';
import { Nav } from "../layout/nav/nav";

@Component({
  selector: 'app-root',
  imports: [Nav],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {

  private http = inject(HttpClient);
  protected readonly title = signal("Dating App");

  // Se cargan los elementos cada vez que se refresca la página
  protected members = signal<any>([]);

  // Otra forma de llamarlo desde el html
  // quedaria de la siguiente forma:
  // <h1>{{title2}}</h1>
  // protected title2 = "Hola";

  // Constructor tradicional que se puede susituir
  // con el de inject
  // constructor(private http2: HttpClient) { }

  async ngOnInit(): Promise<void> {
    this.members.set(await this.getMembers());
  }

  async getMembers(): Promise<object> {
    try {
      return await lastValueFrom(this.http.get("https://localhost:5001/api/members"))
    } catch (error) {
      console.log(error);
      throw error;
    }
  }

}

