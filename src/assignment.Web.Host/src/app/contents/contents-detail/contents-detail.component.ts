import { Component, OnInit, Injector } from '@angular/core';
import { ActivatedRoute, Router, Params } from '@angular/router';
import { ContentServiceProxy, GetContentOutput } from '@shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
  selector: 'app-contents-detail',
  templateUrl: './contents-detail.component.html',
  styleUrls: ['./contents-detail.component.css']
})
export class ContentsDetailComponent extends AppComponentBase implements OnInit {

  content: GetContentOutput = new GetContentOutput();
  contentId: number;

  constructor(
    injector: Injector,
    private _contentService: ContentServiceProxy,
    private _router: Router,
    private _activatedRoute: ActivatedRoute
  ) { 
    super(injector);
  }

  ngOnInit(): void {
    this._activatedRoute.params.subscribe((params:Params) => {
      this.contentId = params['contentId'];
      this.loadContent();
    })
  }

  // Load the content from the specified id
  loadContent() {
    this._contentService.getCMSContent(this.contentId)
      .subscribe((result: GetContentOutput)=>{
        this.content = result;
      });
  }

}
