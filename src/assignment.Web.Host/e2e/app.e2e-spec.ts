import { assignmentTemplatePage } from './app.po';

describe('assignment App', function() {
  let page: assignmentTemplatePage;

  beforeEach(() => {
    page = new assignmentTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
