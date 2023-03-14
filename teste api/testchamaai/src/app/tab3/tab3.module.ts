import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { Tab3PageRoutingModule } from './tab3-routing.module';

import { Tab3Page } from './tab3.page';
import { MenusPageModule } from '../components/menus/menus.module';
import { NavbarPageModule } from '../components/navbar/navbar.module';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    Tab3PageRoutingModule,
    MenusPageModule,
    NavbarPageModule
  ],
  declarations: [Tab3Page]
})
export class Tab3PageModule {}
