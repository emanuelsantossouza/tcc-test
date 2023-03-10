import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-menus',
  templateUrl: './menus.page.html',
  styleUrls: ['./menus.page.scss'],
})
export class MenusPage implements OnInit {

  public appPages = [
    { title: 'Historicos de corridas', url: '/folder/Spam', icon: 'time' },
    { title: 'Configurações', url: '/folder/Spam', icon: 'cog' },
    { title: 'Favoritos', url: '/folder/Favorites', icon: 'heart' },
    { title: 'Ajuda', url: '/folder/Favorites', icon: 'information' },
    { title: 'Sobre nós', url: '/folder/Favorites', icon: 'people' },
    { title: 'Fale Conosco', url: '/folder/Favorites', icon: 'chatbubbles' },
  ];

  public labels = ['Family', 'Friends', 'Notes', 'Work', 'Travel', 'Reminders'];


  constructor() { }

  ngOnInit() {
  }

}
