import { Component } from '@angular/core';
import { NgModule } from '@angular/core';

import { BrowserModule } from '@angular/platform-browser';

import { FormsModule } from '@angular/forms';


import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import {MatInputModule} from '@angular/material/input';

import {MatButtonModule} from '@angular/material/button';

  

@NgModule({

  imports:      [ BrowserModule, FormsModule, MatInputModule, MatButtonModule ],

  declarations: [ AppComponent ],

  bootstrap:    [ AppComponent ]

})

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Angular Upload Multiple Files';
}