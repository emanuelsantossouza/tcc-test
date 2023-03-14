import { Component, ViewChild, ViewChildren } from '@angular/core';
import { IonSlides } from '@ionic/angular';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})
export class Tab1Page {

 

  public slidesOptions: any = { slidesPerView: 3, spaceBetween: 10, freeModel: true}
}
