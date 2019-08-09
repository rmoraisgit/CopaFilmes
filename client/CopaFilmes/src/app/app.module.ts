import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutesModule } from './app.routes.module';
import { HomeModule } from './home/home.module';
import { CopaFilmesModule } from './copa-filmes/copa-filmes.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutesModule,
    HomeModule,
    CopaFilmesModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }