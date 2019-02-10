import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-ilog',
  templateUrl: './ilog.component.html',
  styleUrls: ['./ilog.component.css']
})
export class IlogComponent implements OnInit {
  ilogs: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getIlogs();
  }

  getIlogs() {
    this.http.get('http://localhost:5000/api/integrationlog').subscribe(resp => {
      this.ilogs = resp;
    }, err => {
      console.log(err);
    });
  }
}
