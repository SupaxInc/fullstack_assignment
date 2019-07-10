import { Injectable, OnInit } from '@angular/core';
import { GetContentOutput, ContentServiceProxy } from '@shared/service-proxies/service-proxies';

@Injectable({
  providedIn: 'root'
})
export class ContentsService implements OnInit{
  contents: GetContentOutput[] = [];
  constructor(private _contentService: ContentServiceProxy) {
    this.loadAllContent();
   }

   ngOnInit() {
   }

  loadAllContent() {
    this._contentService.getAll()
      .subscribe((result: GetContentOutput[]) => {
        this.contents = result;
      });
  }
}
