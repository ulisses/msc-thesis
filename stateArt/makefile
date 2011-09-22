UNAME := $(shell uname -s)
REL=state
PDF=$(REL).pdf
TEX=$(REL).tex

all:$(PDF)

# Compile the PDF file
$(PDF):$(TEX)
ifeq ($(UNAME),Darwin)
	latexmk -e '$$pdflatex=q/pdflatex --shell-escape -synctex=1 %T/' -pdf $(TEX)
endif
ifeq ($(UNAME),Linux)
	latexmk -pdf $(TEX)
endif

# open PDF file
open:$(PDF)
ifeq ($(UNAME),Darwin)
	open $(PDF)
endif
ifeq ($(UNAME),Linux)
	xpdf $(PDF)
endif

# Clean rules
clean:
	@echo "Cleaning the shop"
	@find . -maxdepth 1 \( \! -iname README* \! -iname .gitignore \! -iname "*.bib" \! -iname "*.tex" -type f \! -iname "makefile" \! -iname "*.sty" \! -iname "*.cls" \) -exec rm '{}' \;
	@find . \( -name *~ -or -name *.*~ \) -exec rm '{}' \;
	@rm -f *-dot2tex-*

